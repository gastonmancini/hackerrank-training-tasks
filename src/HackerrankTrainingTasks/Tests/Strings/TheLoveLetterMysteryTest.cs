using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class TheLoveLetterMysteryTest
    {
        private TheLoveLetterMystery _theLoveLetterMystery;

        [TestInitialize]
        public void Initialize()
        {
            _theLoveLetterMystery = new TheLoveLetterMystery();
        }

        #region Example Tests

        [TestMethod]
        public void TheLoveLetterMystery_Example_Test_1()
        {
            Assert.AreEqual(2, _theLoveLetterMystery.solution("abc"));
        }

        [TestMethod]
        public void TheLoveLetterMystery_Example_Test_2()
        {
            Assert.AreEqual(0, _theLoveLetterMystery.solution("abcba"));
        }

        [TestMethod]
        public void TheLoveLetterMystery_Example_Test_3()
        {
            Assert.AreEqual(4, _theLoveLetterMystery.solution("abcd"));
        }

        [TestMethod]
        public void TheLoveLetterMystery_Example_Test_4()
        {
            Assert.AreEqual(2, _theLoveLetterMystery.solution("cba"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
