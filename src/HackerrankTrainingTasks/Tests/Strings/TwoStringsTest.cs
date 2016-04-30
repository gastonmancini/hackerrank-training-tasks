using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class TwoStringsTest
    {
        private TwoStrings _twoStrings;

        [TestInitialize]
        public void Initialize()
        {
            _twoStrings = new TwoStrings();
        }

        #region Example Tests

        [TestMethod]
        public void TwoStrings_Example_Test_1()
        {
            Assert.IsTrue(_twoStrings.solution("hello", "world"));
        }

        [TestMethod]
        public void TwoStrings_Example_Test_2()
        {
            Assert.IsFalse(_twoStrings.solution("hi", "world"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
