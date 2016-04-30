using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class GameofThronesITest
    {
        private GameofThronesI _gameofThronesI;

        [TestInitialize]
        public void Initialize()
        {
            _gameofThronesI = new GameofThronesI();
        }

        #region Example Tests

        [TestMethod]
        public void GameofThronesI_Example_Test_1()
        {
            Assert.IsTrue(_gameofThronesI.solution("aaabbbb"));
        }

        [TestMethod]
        public void GameofThronesI_Example_Test_2()
        {
            Assert.IsFalse(_gameofThronesI.solution("cdefghmnopqrstuvw"));
        }

        [TestMethod]
        public void GameofThronesI_Example_Test_3()
        {
            Assert.IsTrue(_gameofThronesI.solution("cdcdcdcdeeeef"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
