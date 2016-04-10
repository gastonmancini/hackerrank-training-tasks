using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class AlternatingCharactersTest
    {
        private AlternatingCharacters _alternatingCharacters;

        [TestInitialize]
        public void Initialize()
        {
            _alternatingCharacters = new AlternatingCharacters();
        }

        #region Example Tests

        [TestMethod]
        public void AlternatingCharacters_Example_Test_1()
        {
            var input = "AAAA";
            Assert.AreEqual(3, _alternatingCharacters.solution(input));
        }

        [TestMethod]
        public void AlternatingCharacters_Example_Test_2()
        {
            var input = "BBBBB";
            Assert.AreEqual(4, _alternatingCharacters.solution(input));
        }

        [TestMethod]
        public void AlternatingCharacters_Example_Test_3()
        {
            var input = "ABABABAB";
            Assert.AreEqual(0, _alternatingCharacters.solution(input));
        }

        [TestMethod]
        public void AlternatingCharacters_Example_Test_4()
        {
            var input = "BABABA";
            Assert.AreEqual(0, _alternatingCharacters.solution(input));
        }

        [TestMethod]
        public void AlternatingCharacters_Example_Test_5()
        {
            var input = "AAABBB";
            Assert.AreEqual(4, _alternatingCharacters.solution(input));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
