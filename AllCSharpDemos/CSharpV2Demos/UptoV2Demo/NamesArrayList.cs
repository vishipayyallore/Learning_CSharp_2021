using System;
using System.Collections;
using Utilities.Generator;

namespace UptoV2Demo
{

    public class NamesArrayList : INamesArrayList
    {
        private readonly INameGenerator _nameGenerator;

        public NamesArrayList(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public ArrayList GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            ArrayList names = new();

            for (int index = 0; index < numberOfNames; index++)
            {
                names.Add(_nameGenerator.GenerateName(nameLength));
            }

            return names;
        }

    }

}
