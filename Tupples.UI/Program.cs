using System;
using System.Collections.Generic;
using Tupples.BL;

namespace Tupples.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var roads = new HashSet<(string, string, int)>()
            {
                ("A", "B", 5),
                ("A", "D", 9),

                ("B", "A", 5),
                ("B", "E", 9),

                ("C", "D", 7),
                ("C", "E", 8),

                ("D", "A", 9),
                ("D", "C", 7),
                ("D", "E", 6),

                ("E", "B", 9),
                ("E", "C", 8),
                ("E", "D", 6)
            };

            var graph = new Graph(roads);

            Console.WriteLine("Список всех городов: {0}", graph.GetAllCitites());
            Console.WriteLine("Сумма всех направлений: {0}", graph.SumOfDirections());
        }
    }
}