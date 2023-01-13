using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace Meterológia
{
    internal class Feladatok
    {
        List<Meteror> lista = new List<Meteror>();
        public Feladatok(string fajlnev)
        {
            this.lista = lista;
            Beolvas(fajlnev);
        }
        public void Beolvas(string fajlnev)
        {
            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');
                string szelirany = Convert.ToString(line[2][0]) + Convert.ToString(line[2][1]) + Convert.ToString(line[2][2]);
                string erosseg = Convert.ToString(line[2][3]) + Convert.ToString(line[2][4]);
                lista.Add(new Meteror(line[0], line[1], szelirany, erosseg, Convert.ToInt32(line[3])));
            }
            sr.Close();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

        }

        public string UtolsoMeresiAdatIdopontja(string varosKod)
        {
            string utolsoIdo = "Hiba az elsoben";
            foreach (var item in lista)
            {
                if (item.Telepules == varosKod.ToUpper())
                {
                    utolsoIdo = item.Ido;
                }
            }
            return utolsoIdo;
        }
        public void feladat03()
        {
            int also = 999;
            string alsonev = "";
            string alsoido = "";
            int felso = 0;
            string felsonev = "";
            string felsoido = "";
            foreach (var item in lista)
            {
                if (item.Homerseklet < also)
                {
                    also = item.Homerseklet;
                    alsonev = item.Telepules;
                    alsoido = item.Ido;
                }
                if (item.Homerseklet > felso)
                {
                    felso = item.Homerseklet;
                    felsonev = item.Telepules;
                    felsoido = item.Ido;
                }
            }
            Console.WriteLine("3. feladat");
            Console.WriteLine($"\tA legalacsonyabb homerseklet: {alsonev} {alsoido} {also} fok");
            Console.WriteLine($"\tA legmagasabb  homerseklet: {felsonev} {felsoido} {felso} fok");


        }
        public List<string> feladat04()
        {
            var lis = new List<string>();
            var nincs=new List<string>();
            foreach (var item in lista)
            {
                if (item.Irany == "000" && item.Ero == "00")
                {
                   lis.Add($"{item.Telepules} : {item.Ido}");
                }
            }
            if (lis.Count == 0)
            {
                nincs.Add("Nem volt szélcsend a mérések idején.");
            }
            else
            {
                return lis;
            }
            return nincs;
        }




        
        public void feladat05()
        {
            Dictionary<string, int[]> output = new Dictionary<string, int[]>();
            int[] ints = {01,07,13,19};
            foreach (var item in lista)
            {
                if (!output.Keys.Contains(item.Telepules)&& ints.IndexOf(ints,Convert.ToString(item.Ido)))
                {

                    output.Add(item.Telepules, (item.Homerseklet, 1));
                }
                else
                {
                    output[item.Telepules][0] += item.homerseklet;
                    output[item.Telepules][1]] ++;
                }
            }
            foreach (var item in output)
            {

            }
        }
        public void feladat6()
        {
            StreamWriter sw = new StreamWriter("");
        }


    }
}
