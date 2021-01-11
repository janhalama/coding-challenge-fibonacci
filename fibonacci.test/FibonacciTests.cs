using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace fibonacci.test
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void TestFibonacciOutput()
        {
            var testVectors = new[] {
                ( Input : 0, Output : 1 ),
                ( Input : 1, Output : 1 ),
                ( Input : 2, Output : 2 ),
                ( Input : 3, Output : 3 ),
                ( Input : 4, Output : 5 ),
                ( Input : 5, Output : 8 ),
                ( Input : 6, Output : 13 ),
                ( Input : 30, Output : 1346269 ),
            };
            foreach (var testVector in testVectors)
            {
                Assert.AreEqual(testVector.Output, Fibonacci.Calculate(testVector.Input));
            }
        }
    }
}
