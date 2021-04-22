using System;
using Utilities.Generator;

namespace UptoV2Demo
{

    public class NamesArray : INamesArray
    {
        private readonly INameGenerator _nameGenerator;
        const int NameLength = 10;

        public NamesArray(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public string[] GenerateNames(int numberOfNames)
        {
            string[] names = new string[numberOfNames];

            for (int index = 0; index < numberOfNames; index++)
            {
                names[index] = _nameGenerator.GenerateName(NameLength);
            }

            return names;
        }
    }

}
