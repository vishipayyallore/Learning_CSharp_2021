using System;
using System.Text;

namespace Utilities.Generator
{

    public static class NameGenerator
    {

        private static readonly string[] _consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };

        private static readonly string[] _vowels = { "a", "e", "i", "o", "u", "ae", "y" };

        static readonly Random _random = new();

        static public string GenerateName(int length)
        {
            StringBuilder name = new(length);
            int index = 2;

            name.Append(_consonants[_random.Next(0, _consonants.Length)]);
            name.Append(_vowels[_random.Next(0, _vowels.Length)]);

            while (index < length)
            {
                name.Append(_consonants[_random.Next(0, _consonants.Length)]);
                name.Append(_vowels[_random.Next(0, _vowels.Length)]);

                index += 2;
            }

            return name.ToString();
        }

    }
}
