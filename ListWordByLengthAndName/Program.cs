using System;
using System.Collections.Generic;
using System.Linq;

namespace ListWordByLengthAndName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays a list of string according to the word length and than by the first letter of the word");

            List<string> cities = new List<string>() { "Warsaw", "Rome", "Paris", "Lisbon", "New York", "London", "Berlin", "Moscow", "Oslo", "Madrid", "Barcelona" };

            var orderedList = cities.OrderBy(city => city.Length).ThenBy(city => city[0]);

            var orderedListQuery = from city in cities
                                   orderby city.Length, city[0]
                                   select city;

            Console.WriteLine("First check by LINQ lambda expression:");
            foreach ( var city in orderedList)
            {
                Console.WriteLine(city);
            }
            
            Console.WriteLine("Second check by LINQ query syntax:");
            foreach (var city in orderedListQuery)
            {
                Console.WriteLine(city);
            }
            Console.ReadKey();
        }
    }
}
