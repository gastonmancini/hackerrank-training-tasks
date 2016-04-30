using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class MakeItAnagramTest
    {
        private MakeItAnagram _makeItAnagram;

        [TestInitialize]
        public void Initialize()
        {
            _makeItAnagram = new MakeItAnagram();
        }

        #region Example Tests

        [TestMethod]
        public void MakeItAnagram_Example_Test_1()
        {
            Assert.AreEqual(4, _makeItAnagram.solution("cde", "abc"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
