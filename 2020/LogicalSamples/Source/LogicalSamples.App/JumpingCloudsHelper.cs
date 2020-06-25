
using static System.Console;

namespace LogicalSamples.App
{
    public class JumpingCloudsHelper
    {

        public void Execute()
        {
            int[] items = { 0, 0, 1, 0, 0, 1, 1, 0 };
            int jumps = 2;
            IJumpingClouds jumpingClouds = new JumpingClouds();

            // Scenario 1
            var energy = jumpingClouds.jumpingOnClouds(items, jumps);
            WriteLine($"Energy: {energy}");

            // Scenario 2
            items = new int[] { 0, 0, 1, 0 };
            energy = jumpingClouds.jumpingOnClouds(items, jumps);
            WriteLine($"Energy: {energy}");

            // Scenario 3
            items = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            jumps = 3;
            energy = jumpingClouds.jumpingOnClouds(items, jumps);
            WriteLine($"Energy: {energy}");
        }

    }
}
