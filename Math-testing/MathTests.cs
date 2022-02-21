using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Operation_Library;


namespace Math_testing
{
    [TestClass]
    public class MathTests
    {
        //test method for addition
        [TestMethod]
        [DataRow("1 1", 2)]
        [DataRow("5 5", 10)]
        public void StringAdd(string input, int expected)
        {
            Assert.AreEqual(expected, MathOpterations.Addition(input));
        }

      

    }
}
