using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Spieler_Bruch.Strukturen
{
    internal struct Gambler
    {
        public string Name { get; set; }
        public int Punkte { get; set; }

        public void Ausgabe()
        {
            Console.WriteLine($"{Name,8} | {Punkte,6}");
        }
    }
}
