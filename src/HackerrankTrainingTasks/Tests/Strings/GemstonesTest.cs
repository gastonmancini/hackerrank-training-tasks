using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class GemstonesTest
    {
        private Gemstones _gemstones;

        [TestInitialize]
        public void Initialize()
        {
            _gemstones = new Gemstones();
        }

        #region Example Tests

        [TestMethod]
        public void Gemstones_Example_Test()
        {
            var strings = new[]
            {
                "abcdde", "baccd", "eeabg"
            };

            Assert.AreEqual(2, _gemstones.solution(strings));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
