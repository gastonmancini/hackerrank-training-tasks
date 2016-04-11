using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class FunnyStringTest
    {
        private FunnyString _funnyString;

        [TestInitialize]
        public void Initialize()
        {
            _funnyString = new FunnyString();
        }

        #region Example Tests

        [TestMethod]
        public void FunnyString_Example_Test_Is_Funny()
        {
            Assert.IsTrue(_funnyString.solution("acxz"));
        }

        [TestMethod]
        public void FunnyString_Example_Test_Is_Not_Funny()
        {
            Assert.IsFalse(_funnyString.solution("bcxz"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
