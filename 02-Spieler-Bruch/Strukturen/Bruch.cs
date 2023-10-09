using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_Spieler_Bruch.Strukturen
{
    public struct  Bruch
    {
        private int _zaehler;
        private int _nenner;

        public Bruch(int zaehler, int nenner)
        {
            _zaehler = zaehler;
            _nenner = nenner;
        }

        public int Zaehler { get { return _zaehler; } set { _zaehler = value; } }
        public int Nenner { get { return _nenner; } set { _nenner = value; } }

        public void AusgabeBruch()
        {
            if( _zaehler < _nenner )
            {
                Console.WriteLine($"Ihr Bruch: {Zaehler}/{Nenner}");
            }
            else
            {
                Console.WriteLine($"Ihr Bruch: {Zaehler/Nenner} {Zaehler%Nenner}/{Nenner}");

            }

        }

        public double BruchToDouble()
        {
            return (double)_zaehler/_nenner;
        }

        private void UmkehrBruch()
        {
            int puffer = _zaehler;
            _zaehler = _nenner;
            _nenner = puffer;
        }

        private int GGT()
        {
            int a = _zaehler;
            int b = _nenner;    
            while(b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }

        public void KuerzeBruch()
        {
            int ggt = this.GGT();
            _zaehler /= ggt;
            _nenner /= ggt;
        }


        public Bruch AddBruch(Bruch bruch)
        {
            Bruch ergebnis = bruch;

            ergebnis.Zaehler = _zaehler * bruch._nenner + bruch._zaehler * _nenner;
            ergebnis._nenner = bruch._nenner*_nenner;
            ergebnis.KuerzeBruch();
            return ergebnis;
        }

        public Bruch SubBruch(Bruch bruch)
        {
            Bruch ergebnis = bruch;

            ergebnis.Zaehler = _zaehler * bruch._nenner - bruch._zaehler * _nenner;
            ergebnis._nenner = bruch._nenner * _nenner;
            ergebnis.KuerzeBruch();
            return ergebnis;
        }

        public Bruch MulBruch(Bruch bruch)
        {
            Bruch ergebnis = bruch;

            ergebnis.Zaehler = _zaehler * bruch._zaehler ;
            ergebnis.Nenner = bruch._nenner * _nenner;
            ergebnis.KuerzeBruch();
            return ergebnis;
        }

        public Bruch DivBruch(Bruch bruch)
        {
            Bruch ergebnis = bruch;
            bruch.UmkehrBruch();

            ergebnis.Zaehler = _zaehler * bruch._zaehler;
            ergebnis._nenner = bruch._nenner * _nenner;
            ergebnis.KuerzeBruch();
            return ergebnis;
        }

        public static Bruch operator +(Bruch a) 
        { 
            return a; 
        }
        public static Bruch operator -(Bruch a) => new Bruch(-a._zaehler, a._nenner);

        public static Bruch operator +(Bruch a, Bruch b)
            => new Bruch(a.Zaehler * b.Nenner + b.Zaehler * a.Nenner, a.Nenner * b.Nenner);

        public static Bruch operator -(Bruch a, Bruch b)
            => a + (-b);

        public static Bruch operator *(Bruch a, Bruch b)
            => new Bruch(a.Zaehler * b.Zaehler, a.Nenner * b.Nenner);

        public static Bruch operator /(Bruch a, Bruch b)
        {
            if (b.Zaehler == 0)
            {
                throw new DivideByZeroException();
            }
            return new Bruch(a.Zaehler * b.Nenner, a.Nenner * b.Zaehler);
        }

        public override string ToString() => $"{Zaehler} / {Nenner}";
    }
}
