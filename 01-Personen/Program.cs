using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Personen
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Personen[] pers = new Personen[5];

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Bitte Geben Sie von der {0}. Person den Nachname,Vorname,Bruttogehalt,Steuersatz ein: ", i + 1);
                string eingabe = Console.ReadLine();
                string[] eing = eingabe.Split(',');
                pers[i] = new Personen(eing[1], eing[0], double.Parse(eing[3]), double.Parse(eing[2]));

            }

            //Ausgabe
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Vorname");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("Nachname");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Bruttogehalt");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("Steuersatz");
            Console.SetCursorPosition(60, 10);
            Console.WriteLine("Nettogehalt");


            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < 5; i++)
            {

                Console.SetCursorPosition(0, 12 + i);
                Console.WriteLine(pers[i].vorname);
                Console.SetCursorPosition(15, 12 + i);
                Console.WriteLine(pers[i].nachname);
                Console.SetCursorPosition(30, 12 + i);
                Console.WriteLine(pers[i].bruttog);
                Console.SetCursorPosition(45, 12 + i);
                Console.WriteLine(pers[i].stsatz);
                Console.SetCursorPosition(60, 12 + i);
                Console.WriteLine(pers[i].nettogehalt());
            }

            Console.ReadKey();
        }
    }
}
