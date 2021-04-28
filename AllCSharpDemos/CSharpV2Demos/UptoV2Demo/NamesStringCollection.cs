using System;
using System.Collections.Specialized;
using Utilities.Generator;

namespace UptoV2Demo
{

    public class NamesStringCollection : INamesStringCollection
    {
        private readonly INameGenerator _nameGenerator;

        public NamesStringCollection(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }

        public StringCollection GenerateNames(int numberOfNames = 10, int nameLength = 10)
        {
            StringCollection names = new();

            for (int index = 0; index < numberOfNames; index++)
            {
                names.Add(_nameGenerator.GenerateName(nameLength));
            }

            return names;
        }

    }

}
