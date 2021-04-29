using System;
using System.Collections.Generic;
using Utilities.Generator;

namespace UptoV2Demo
{

    public class NamesListString : INamesListString
    {
        private readonly INameGenerator _nameGenerator;

        public NamesListString(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public List<string> GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            List<string> names = new();

            for (int index = 0; index < numberOfNames; index++)
            {
                names.Add(_nameGenerator.GenerateName(nameLength));
            }

            return names;
        }

    }

}
