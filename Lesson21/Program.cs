using System;
using System.Collections.Generic;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var imput = Console.ReadLine();

            if(int.TryParse(imput, out int result))
            {
                //var isEven = IsEven(result);
                
                if(result.IsEven())
                {
                    Console.WriteLine($"{result} - Even.");
                }
                else
                {
                    Console.WriteLine($"{result} - Not Even.");
                }

                int h = 182;
                h.IsDevideBy(7);

            }
            else
            {
                Console.WriteLine("This is not Even Number");
            }

            Console.ReadLine();

            var roads = new List<Road>();
            for(var i = 0; i < 10; i ++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.CovenvertToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }

       
    }
}
