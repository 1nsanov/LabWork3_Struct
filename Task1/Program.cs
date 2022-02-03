using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var listHockeyPlayers = new List<HockeyPlayer>();
            for (int i = 1; i <= 10; i++)
            {
                var name = "Bezunov " + i;
                var age = rnd.Next(18, 50);
                var countGame = rnd.Next(5, 40);
                var countGoal = rnd.Next(1, 50);
                listHockeyPlayers.Add(new HockeyPlayer(name, age, countGame, countGoal));
            }

            Console.WriteLine("Весь список:");
            OutputList(listHockeyPlayers);

            var averageAge = listHockeyPlayers.Sum(p => p.Age) / listHockeyPlayers.Count;
            Console.WriteLine(averageAge);

            Console.WriteLine("Хоккеисты, возраст которых больше 25 лет.");

            OutputList(listHockeyPlayers.Where(p => p.Age > 25).ToList());

            Console.ReadLine();
        }

        private static void OutputList(List<HockeyPlayer> list)
        {
            Console.WriteLine();
            if (list.Count > 0)
            {
                Console.WriteLine(" Фамилия         | Возраст | Количество игр | Количество заброшенных шайб");
                Console.WriteLine("__________________________________________________________________________");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("__________________________________________________________________________");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
            Console.WriteLine();
        }
    }
}
