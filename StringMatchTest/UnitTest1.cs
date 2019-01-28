using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMatch;

namespace StringMatchTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("1, 26, 51", compares.FindMatches("Polly"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("1, 26, 51", compares.FindMatches("polly"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("3, 28, 53, 78, 82", compares.FindMatches("ll"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("3, 28, 53, 78, 82", compares.FindMatches("Ll"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("<no matches>", compares.FindMatches("X"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("<no matches>", compares.FindMatches("PolyX"));
        }

        [TestMethod]
        public void TestMethod7()
        {
            string input = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("90", compares.FindMatches("tea"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            string input = "aaa";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("1, 2", compares.FindMatches("aa"));
        }

        [TestMethod]
        public void TestMethod9()
        {
            string input = "Polly";
            StringCompares compares = new StringCompares(input);

            Assert.AreEqual("1", compares.FindMatches("polly"));
        }

    }
}
