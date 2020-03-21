using System;
using System.Collections.Generic;

namespace Tupples.BL
{
    public class Graph
    {
        public HashSet<(string, string, int)> Roads { get; set; }
        public HashSet<string> Cities { get; set; }

        public Graph(HashSet<(string, string, int)> roads)
        {
            Roads = roads ?? throw new ArgumentNullException(nameof(roads), "Список дорог не может быть равен null.");

            var cities = new HashSet<string>();

            foreach(var road in Roads)
            {
                cities.Add(road.Item1);
                cities.Add(road.Item2);
            }

            Cities = cities ?? throw new ArgumentNullException(nameof(cities), "Список городов не может быть равен null.");
        }

        public string GetAllCitites()
        {
            var res = "";

            foreach (var city in Cities)
                res += city + " ";

            return res;
        }

        public string NearbySities()
        {
            var min = 0;
            var minCities = new string[2];
            foreach (var road in Roads)
                if (road.Item3 > min)
                    min = road.Item3;

            foreach(var city1 in Cities)
                foreach(var city2 in Cities)
                {
                    if (city1 == city2)
                        continue;

                    var roadWeight = FindMinRoad(city1, city2);

                    if (roadWeight < min)
                    {
                        min = roadWeight;
                        minCities[0] = city1;
                        minCities[1] = city2;
                    }
                }

            var res = minCities[0] + " - " + minCities[1];
            return res;
        }

        private int FindMinRoad(string city1, string city2, bool nextStep = false)
        {
            throw new NotImplementedException();
        }

        public int SumOfDirections()
        {
            var sum = 0;

            foreach (var road in Roads)
                sum += road.Item3;

            return sum;
        }
    }
}