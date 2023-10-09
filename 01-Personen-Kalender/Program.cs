using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kalender
{

    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Geben Sie das Jahr an für den Sie das Kalender ertsellen wollen: ");
            //int jahr = int.Parse(Console.ReadLine());
            //int[] x = new int[12];
            //int tag = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i + 1 <= 7)
            //    {
            //        if (i + 1 == 2 && jahr % 4 != 0)
            //            x[i] = 28;
            //        if (i + 1 == 2 && jahr % 4 == 0)
            //            x[i] = 29;
            //        if ((i + 1) % 2 != 0)
            //            x[i] = 31;
            //        if ((i + 1) % 2 == 0 && i + 1 != 2)
            //            x[i] = 30;
            //    }
            //    else if (i + 1 > 7)
            //    {
            //        if ((i + 1) % 2 == 0)
            //            x[i] = 31;
            //        if ((i + 1) % 2 != 0)
            //            x[i] = 30;
            //    }

            //    Console.Write("{0} ", x[i]);

            //}
            //Console.ReadKey();

            //int x1 = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x1 = x1 + x[i];
            //}

            //Datum[] date = new Datum[x1];

            //for (int i = 1; i < x.Length + 1; i++)
            //{

            //    for (int j = 1; j < x[i - 1] + 1; j++)
            //    {

            //        date[tag] = new Datum(j, i, jahr);
            //        tag++;


            //    }
            //}
            //Console.WriteLine();
            //Console.ReadKey();


            //for (int count = 0; count < x1; count++)
            //{
            //    Console.WriteLine("Tag: {0,2} Monat: {1,2} Jahr: {2,4}", date[count].Tag, date[count].Monat, date[count].Jahr);
            //}
            int[] x = { 1, 2, 3 };
            Console.WriteLine(Sum(x));
            Console.WriteLine(Sum(2));
            Console.WriteLine(Sum(3,3,4,5,6,7));
            Console.ReadKey();
        }


        static int Sum(params int[] x)
        {
            int sum = 0;

            if (x.Length > 0)
            {
                for(int i = 0;i < x.Length; i++)
                {
                    sum += x[i];
                }
            }
            return sum;
        }
    }

}
