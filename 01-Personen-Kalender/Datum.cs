using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kalender
{
    public struct Datum
    {
        private readonly int tag;
        private readonly int monat;
        private readonly int jahr;

        public Datum(int t, int m, int j)
        {
            tag = t;
            monat = m;
            jahr = j;

        }

        public int Tag { get { return tag; } }
        public int Monat { get { return monat; } }
        public int Jahr { get { return jahr; } }

    }
}
