using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeNamespace;

namespace Problem_04_UnitTest
{
    [TestClass]
    public class Problem_04_UnitTest
    {
        [TestMethod]
        public void TestProblem_04_01()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = CountOfNumberInArray.CountOfGivenNumberInArray(3,myArray);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestProblem_04_02()
        {
            int[] myArray = { 1, 2, 3, 1, 5, 6, 7, 1, 9, 10 };
            int result = CountOfNumberInArray.CountOfGivenNumberInArray(1, myArray);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestProblem_04_03()
        {
            int[] myArray = { 2, 2, 3, 2, 5, 6, 7, 2, 9, 2 };
            int result = CountOfNumberInArray.CountOfGivenNumberInArray(2, myArray);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestProblem_04_04()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = CountOfNumberInArray.CountOfGivenNumberInArray(0, myArray);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestProblem_04_05()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = CountOfNumberInArray.CountOfGivenNumberInArray(89, myArray);
            Assert.AreEqual(0, result);
        }
    }
}
