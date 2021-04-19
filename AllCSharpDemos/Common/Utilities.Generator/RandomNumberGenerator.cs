using System;

namespace Utilities.Generator
{

    public class RandomNumberGenerator
    {
        static readonly Random _random = new();

        static public int GetRandomValue(int start = 8, int end = 50)
        {
            return _random.Next(start, end);
        }

    }

}
