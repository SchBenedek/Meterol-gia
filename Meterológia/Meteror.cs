using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meterológia
{
    internal class Meteror
    {
        private string telepules;
        private string ido;
        private string irany;
        private string ero;
        private int homerseklet;

        public Meteror(string telepules, string ido, string irany, string ero, int homerseklet)
        {
            this.telepules = telepules;
            this.ido = ido;
            this.irany = irany;
            this.ero = ero;
            this.homerseklet = homerseklet;
        }

        public string Telepules { get => telepules; set => telepules = value; }
        public string Ido { get => ido; set => ido = value; }
        public string Irany { get => irany; set => irany = value; }
        public string Ero { get => ero; set => ero = value; }
        public int Homerseklet { get => homerseklet; set => homerseklet = value; }

        public override string ToString()
        {
            return $"{this.telepules}, {this.ido}, {this.irany}, {this.ero}, {this.homerseklet}";
        }
    }

}
