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

        //test method for subtraction
        [TestMethod]
        [DataRow("5 1", 4)]
        [DataRow("15 5", 10)]
        public void StringSub(string input, int expected)
        {
            Assert.AreEqual(expected, MathOpterations.Subtraction(input));
        }

        //test method for multiplication
        [TestMethod]
        [DataRow("7 2", 14)]
        [DataRow("10 5", 50)]
        public void StringMul(string input, int expected)
        {
            Assert.AreEqual(expected, MathOpterations.Multiplication(input));
        }

        //test method for division
        [TestMethod]
        [DataRow("4 2", 2)]
        [DataRow("18 3", 6)]
        public void StringDiv(string input, int expected)
        {
            Assert.AreEqual(expected, MathOpterations.Division(input));
        }



    }
}
