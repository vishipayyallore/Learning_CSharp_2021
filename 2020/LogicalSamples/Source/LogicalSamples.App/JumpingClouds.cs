namespace LogicalSamples.App
{
    public class JumpingClouds : IJumpingClouds
    {

        public int jumpingOnClouds(int[] items, int jumps)
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
