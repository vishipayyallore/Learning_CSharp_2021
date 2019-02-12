using Learn.CSharp7.Common;
using Learn.TuplesDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.TuplesDemoTests
{
    [TestClass]
    public class TuplesTypeDemoTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDemoDataType tupleDataTypeDemo = new DemoTuples();

            tupleDataTypeDemo.ShowDemo(System.ConsoleColor.Green);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }

    }
}
