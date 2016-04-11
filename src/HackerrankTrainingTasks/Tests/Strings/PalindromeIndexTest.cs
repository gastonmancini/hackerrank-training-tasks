using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class PalindromeIndexTest
    {
        private PalindromeIndex _palindromeIndex;

        [TestInitialize]
        public void Initialize()
        {
            _palindromeIndex = new PalindromeIndex();
        }

        #region Example Tests

        [TestMethod]
        public void PalindromeIndex_Example_Test_1()
        {
            Assert.AreEqual(3, _palindromeIndex.solution("aaab"));
        }

        [TestMethod]
        public void PalindromeIndex_Example_Test_2()
        {
            Assert.AreEqual(0, _palindromeIndex.solution("baa"));
        }

        [TestMethod]
        public void PalindromeIndex_Example_Test_3()
        {
            Assert.AreEqual(-1, _palindromeIndex.solution("aaa"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
