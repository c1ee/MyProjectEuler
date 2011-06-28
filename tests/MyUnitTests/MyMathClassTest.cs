using MyMathFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ProjectEuler;

namespace MyUnitTests
{
    
    
    /// <summary>
    ///This is a test class for MyMathClassTest and is intended
    ///to contain all MyMathClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyMathClassTest
    {
        private ProjectEuler.ProblemHelper helper;
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            helper = new ProblemHelper();
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FindNthPrime passing in an invalid argument
        ///</summary>
        [TestMethod()]
        public void FindNthPrimeInvalidArgumentsFailTest()
        {
            MyMathClass target = new MyMathClass(); 
            long actual;
            try
            {
                actual = target.FindNthPrime(0);
                Assert.Fail("ArgumentOutOfRangeException failed to generate");                
            }
            catch (ArgumentOutOfRangeException e)
            {
                return; // pass condition reached
            }
            catch(Exception)
            {
                Assert.Fail("Unknown exception thrown");                
            }
        }

        /// <summary>
        ///A test for FindNthPrime with valid arguments
        ///</summary>
        [TestMethod()]
        public void FindNthPrimeTest()
        {
            MyMathClass target = new MyMathClass();
            int index = 1;
            long expected = 2;
            long actual;

            actual = target.FindNthPrime(index);
            Assert.AreEqual(expected, actual);

            index = 2;
            expected = 3;
            actual = target.FindNthPrime(index);
            Assert.AreEqual(expected, actual);

            index = 10;
            expected = 29;
            actual = target.FindNthPrime(index);
            Assert.AreEqual(expected, actual);

            index = 100;
            expected = 541;
            actual = target.FindNthPrime(index);
            Assert.AreEqual(expected, actual);

            index = 149;
            expected = 859;
            actual = target.FindNthPrime(index);
            Assert.AreEqual(expected, actual);

        }

        ///// <summary>
        /////A test for GetListOfPrimesUpTo
        /////</summary>
        //[TestMethod()]
        //public void GetListOfPrimesUpToTest()
        //{
        //    MyMathClass target = new MyMathClass(); // TODO: Initialize to an appropriate value
        //    long maxNumber = 0; // TODO: Initialize to an appropriate value
        //    List<long> expected = null; // TODO: Initialize to an appropriate value
        //    List<long> actual;
        //    actual = target.GetListOfPrimesUpTo(maxNumber);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        /// <summary>
        ///A test for GetSumOfPrimesUpTo
        ///</summary>
        [TestMethod()]
        public void GetSumOfPrimesUpToTest()
        {
            MyMathClass target = new MyMathClass();
            long number = 2000000;
            long expected = 142913828922;
            long actual;
            actual = target.GetSumOfPrimesUpTo(number);
            Assert.AreEqual(expected, actual);            
        }

        /// <summary>
        ///A test for IsPrime
        ///</summary>
        [TestMethod()]
        public void IsPrimeTest()
        {
            long number = 2;
            bool expected = true;
            bool actual;

            actual = MyMathClass.IsPrime(number);
            Assert.AreEqual(expected, actual);

            number = 4;
            expected = false;
            actual = MyMathClass.IsPrime(number);
            Assert.AreEqual(expected, actual);

            number = 7;
            expected = true;
            actual = MyMathClass.IsPrime(number);
            Assert.AreEqual(expected, actual);

            number = 7919;
            expected = true;
            actual = MyMathClass.IsPrime(number);
            Assert.AreEqual(expected, actual);

            number = 7923;
            expected = false;
            actual = MyMathClass.IsPrime(number);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetGreatestProductTest
        ///</summary>
        [TestMethod()]
        public void GetGreatestProductTest()
        {
            int[][] grid = helper.PE11Grid;
            int adjacentCount = 4;
            long product = MyMathClass.GetGreatestAdjacentProductInGrid(grid, adjacentCount);
            throw new NotImplementedException();
        }        
    }
}
