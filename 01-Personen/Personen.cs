using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Personen
{
    struct Personen
    {
        public string vorname;
        public string nachname;
        public double stsatz;
        public double bruttog;

        public Personen(string vona, string nana, double stesa, double brge)
        {
            vorname = vona;
            nachname = nana;
            stsatz = stesa;
            bruttog = brge;
        }

    

        public double nettogehalt()
        {
            return bruttog - (bruttog * stsatz / 100);
        }


    }
}
