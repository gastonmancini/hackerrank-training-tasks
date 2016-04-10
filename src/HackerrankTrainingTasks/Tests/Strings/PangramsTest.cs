using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class PangramsTest
    {
        private Pangrams _pangrams;

        [TestInitialize]
        public void Initialize()
        {
            _pangrams = new Pangrams();
        }

        #region Example Tests

        [TestMethod]
        public void Pangrams_Example_Test_Is_Panagram()
        {
            var phrase = "The quick brown fox jumps over the lazy dog";
            Assert.IsTrue(_pangrams.solution(phrase));
        }

        [TestMethod]
        public void Pangrams_Example_Test_Is_Panagram_2()
        {
            var phrase = "We promptly judged antique ivory buckles for the next prize";
            Assert.IsTrue(_pangrams.solution(phrase));
        }

        [TestMethod]
        public void Pangrams_Example_Test_Is_Not_Panagram()
        {
            var phrase = "We promptly judged antique ivory buckles for the prize";
            Assert.IsFalse(_pangrams.solution(phrase));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
