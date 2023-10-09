using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[100];

            ConsoleKey eingabe = ConsoleKey.A;
            do
            {
                Console.Clear();
                Console.Write("Bitte geben Sie die gewünschte Aktion" +
                    "\n1. Produkt hinzufügen" +
                    "\n2. Preis eines Produkts ändern" +
                    "\n3. Lagerbestand eines Produkts anzeigen" +
                    "\n4. Kompletten Lagerbestand anzeigen" +
                    "\n Beenden können Sie das Programm mit Escape,x oder der Taste 5." +
                    "\n Ihre Aktione: ");

                eingabe = Console.ReadKey().Key;
                Console.WriteLine();
                switch (eingabe)
                {
                    case ConsoleKey.D1:
                        AddProduct(products);
                        break;
                    case ConsoleKey.D2:
                        ChangePrice(products);
                        break;
                    case ConsoleKey.D3:
                        ShowInventoryOfAProduct(products);
                        break;
                    case ConsoleKey.D4:
                        ShowInventory(products);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.Escape:
                    case ConsoleKey.X:
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }

            } while (eingabe != ConsoleKey.Escape && eingabe != ConsoleKey.X && eingabe != ConsoleKey.D5);
        }

        static void AddProduct(Product[] products)
        {
            Console.Clear();
            ConsoleKey eingabe = ConsoleKey.A;
            Console.Write("Bitte geben Sie das Produkt ein mit Semikolon getrennt (Produktname;Preis;Lagerbestand): ");
            string[] eingabeProdukt = Console.ReadLine().Split(';');
            if (eingabeProdukt.Length < 3)
            {
                Console.WriteLine("Falsche Eingabe bitte erneut versuchen drücken Sie eine beliebige Taste!!");
                Console.ReadKey();
                AddProduct(products);
            }

            Product product = new Product();
            product.Name = eingabeProdukt[0];
            if (!decimal.TryParse(eingabeProdukt[1], out product.Price) || !int.TryParse(eingabeProdukt[2], out product.Inventory))
            {
                Console.WriteLine("Falsche Eingabe bitte erneut versuchen drücken Sie eine beliebige Taste!!");
                Console.ReadKey();
                AddProduct(products);
            }
            int index = 0;
            while (products[index].Name != null)
            {
                index++;
            }
            products[index] = product;
            do
            {
                Console.Write("Möchten Sie eine weiteren Produkt eingeben J für ja N für nein: ");
                eingabe = Console.ReadKey().Key;
                Console.WriteLine();
                switch (eingabe)
                {
                    case ConsoleKey.J:
                        AddProduct(products);
                        break;
                    case ConsoleKey.N:
                        break;

                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }

            } while (eingabe != ConsoleKey.N);
        }
        static void ChangePrice(Product[] products)
        {

            int index = -1;

            Console.Write("Bitte geben Sie das Produkt ein von dem Sie den Preis ändern möchten: ");
            string produkt = Console.ReadLine();

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name.ToLower() == produkt.ToLower())
                {
                    index = i;
                    break;
                }
            }

            decimal price = 0;
            string eingabe = "";
            while (!decimal.TryParse(eingabe, out price))
            {
                Console.Clear();
                Console.Write("Bitte geben Sie den neuen Preis des Produktes ein: ");
                eingabe = Console.ReadLine();
            }

            if (index > -1)
                products[index].Price = price;
            else
                Console.WriteLine("Produkt nicht vorhanden!");
        }

        static void ShowInventoryOfAProduct(Product[] products)
        {

        }

        static void ShowInventory(Product[] products)
        {
            Console.Clear();
            foreach (Product product in products)
            {
                if (product.Name != null)
                    Console.WriteLine($"{product.Name} {product.Price} {product.Inventory}");
            }

            Console.WriteLine("Für das Hauptmenü drücken Sie eine beliebige Taste");
            Console.ReadKey();
        }
    }
}
