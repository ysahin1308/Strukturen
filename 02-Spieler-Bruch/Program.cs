using _02_Spieler_Bruch.Strukturen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02_Spieler_Bruch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gambler[] spieler = new Gambler[10];

            //for (int i = 0; i < spieler.Length; i++)
            //{
            //    Console.Write("Bitte geben Sie den Spielernamen und Punktestand ein (Name,Punkt): ");
            //    string eingabe = Console.ReadLine();

            //    string[] eingaben = eingabe.Split(',');

            //    spieler[i].Name = eingaben[0];
            //    spieler[i].Punkte = int.Parse(eingaben[1]);


            //}
            //SortGambler(spieler);

            //Console.WriteLine("{0,8} | {1,6}","Name","Punkte");

            //foreach (var x in spieler)
            //    x.Ausgabe();

            
            

            Bruch bruch = new Bruch();
            Bruch bruch1 = new Bruch();

            

            bruch.Zaehler = 2;
            bruch.Nenner = 3;

            bruch1.Zaehler = 4;
            bruch1.Nenner = 12;


            Console.WriteLine((bruch + bruch1));
            //Bruch ergebnis = bruch.AddBruch(bruch1);
            //ergebnis.AusgabeBruch();

            //bruch.MulBruch(bruch1).AusgabeBruch();

            //bruch.DivBruch(bruch1).AusgabeBruch();

            //bruch.SubBruch(bruch1).AusgabeBruch();

            
            Console.ReadKey();

        }

        static void SortGambler(Gambler[] spieler)
        {
            for (int i = 0;i < spieler.Length; i++)
            {
                for(int j = 0;j<spieler.Length-1-i;j++)
                {
                    if (spieler[j].Punkte < spieler[j + 1].Punkte)
                    {
                        Gambler puffer = spieler[j];
                        spieler[j] = spieler[j + 1];
                        spieler[j+1] = puffer;
                    }
                }
            }
        }
    }
}
