using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Generator;

namespace Utilities.GeneratorTests
{

    [TestClass]
    public class NameGeneratorTests
    {
        readonly NameGenerator _nameGenerator = new();

        [TestMethod]
        public void When_10Digits_Name_Is_Requested()
        {
            for (int i = 0; i < 1_00_00_000; i++)
            {
                var name = _nameGenerator.GenerateName(10);

                Assert.IsNotNull(name);
                Assert.IsTrue(name.Length >= 10);
            }

        }

    }

}
