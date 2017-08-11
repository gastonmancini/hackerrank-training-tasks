using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class SuperReducedStringTest
    {
        private SuperReducedString _superReducedString;

        [TestInitialize]
        public void Initialize()
        {
            _superReducedString = new SuperReducedString();
        }

        [TestMethod]
        public void SuperReducedString_Example_Test1()
        {
            var result = _superReducedString.solution("aaabccddd");

            Assert.AreEqual("abd", result);
        }

        [TestMethod]
        public void SuperReducedString_Example_Test2()
        {
            var result = _superReducedString.solution("baab");

            Assert.AreEqual("Empty String", result);
        }

        [TestMethod]
        public void SuperReducedString_Example_Test3()
        {
            var result = _superReducedString.solution("aa");

            Assert.AreEqual("Empty String", result);
        }
    }
}
