using Learn.CSharp7.Common;
using Learn.TuplesDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.TuplesDemoTests
{
    [TestClass]
    public class TuplesTypeDemoTests
    {
        [TestMethod]
        public void When_ShowDemo_Of_DemoTuples_Called()
        {
            IDataTypeDemo tupleDataTypeDemo = new DemoTuples();

            tupleDataTypeDemo.ShowDemo();
        }

    }
}
