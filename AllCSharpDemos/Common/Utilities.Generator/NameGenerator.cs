using System.Text;

namespace Utilities.Generator
{

    public static class NameGenerator
    {

        private static readonly string[] _consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };

        private static readonly string[] _vowels = { "a", "e", "i", "o", "u", "ae", "y" };


        static public string GenerateName(int length)
        {
            StringBuilder name = new(length);
            int index = 2;

            name.Append(GetAConstant().ToUpper());
            name.Append(GetAVowel());

            while (index < length)
            {
                name.Append(GetAConstant());
                name.Append(GetAVowel());

                index += 2;
            }

            return name.ToString();
        }

        private static string GetAConstant()
        {
            return _consonants[RandomNumberGenerator.GetRandomValue(0, _consonants.Length)];
        }

        private static string GetAVowel()
        {
            return _vowels[RandomNumberGenerator.GetRandomValue(0, _vowels.Length)];
        }
    }
}
