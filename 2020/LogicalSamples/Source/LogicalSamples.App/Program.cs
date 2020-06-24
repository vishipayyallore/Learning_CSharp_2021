using System;

using static System.Console;

namespace LogicalSamples.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] items = { 0, 0, 1, 0, 0, 1, 1, 0 };
            // int[] items = { 0, 0, 1, 0 };
            int[] items = { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            // int jumps = 2;
            int jumps = 3;
            int energy = 100;
            int index = 0;

            do
            {
                energy -= (items[index] == 0) ? 1 : 3;
            } while ((index = (index + jumps) % items.Length) != 0);

            WriteLine($"Energy: {energy}");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        static int jumpingOnClouds(int[] items, int jumps)
        {
            int energy = 100;
            int index = 0;

            do
            {
                energy -= (items[index] == 0) ? 1 : 3;
            } while ((index = (index + jumps) % items.Length) != 0);

            return energy;
        }

    }
}
