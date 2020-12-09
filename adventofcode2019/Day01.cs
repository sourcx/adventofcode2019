using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace adventofcode
{
    class Day01
    {
        public static void start()
        {
            part1();
            part2();
        }

        static void part1()
        {
            var fuel = ComponentFuel();
            Console.WriteLine($"Day 01: Total fuel needed is {fuel}."); // 3363033
        }

        static void part2()
        {
            var fuel = ComponentFuel2();
            Console.WriteLine($"Day 01: Total fuel needed is {fuel}."); // 5041680
        }

        static int ComponentFuel()
        {
            return File.ReadLines("input/1").Select(Int32.Parse).Select(x => (x / 3) - 2).Sum();
        }

        static int ComponentFuel2()
        {
            var totalFuel = 0;
            var components = File.ReadLines("input/1").Select(Int32.Parse);

            foreach (var component in components)
            {
                var fuel = (component / 3) - 2;
                totalFuel += fuel;

                var extraFuel = (fuel / 3) - 2;

                while (extraFuel > 0)
                {
                    Console.WriteLine($"{extraFuel}.");
                    totalFuel += extraFuel;
                    extraFuel = (extraFuel / 3) - 2;
                }
            }

            return totalFuel;
        }
    }
}
