using System;
using Utilities.Generator;

using static System.Console;

namespace Try.Generator
{

    public class TryGeneratorApplication
    {
        private readonly INameGenerator _nameGenerator;

        public TryGeneratorApplication(INameGenerator nameGenerator)
        {
            _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
        }


        // Application starting point
        public void Run()
        {
            var name = _nameGenerator.GenerateName(10);
            WriteLine($"Name: {name}");
        }

    }

}
