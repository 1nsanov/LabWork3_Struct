using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var listProducts = new List<Product>();
            for (int i = 1; i <= 10; i++)
            {
                var name = "Product " + i;
                var startDate = new DateTime(2022, 1, 1).AddDays(rnd.Next(10,30));
                var expiration = rnd.Next(3, 30);
                var price = rnd.Next(2, 100);
                listProducts.Add(new Product(name, startDate, expiration, price));
            }

            OutputList(listProducts);


            Console.ReadLine();
        }


        private static void OutputList(List<Product> list)
        {
            Console.WriteLine();
            if (list.Count > 0)
            {
                Console.WriteLine(" Наименование    | Дата производства | Срок годности(д.) | Цена   | Годен до");
                Console.WriteLine("______________________________________________________________________________");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("______________________________________________________________________________");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
            Console.WriteLine();
        }
    }
}
