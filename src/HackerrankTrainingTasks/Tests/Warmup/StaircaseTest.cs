using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class StaircaseTest
    {
        private Staircase _staircase;

        [TestInitialize]
        public void Initialize()
        {
            _staircase = new Staircase();
        }

        #region Example Tests

        [TestMethod]
        public void Staircase_Example_Test()
        {
            var expectedResult = "     #" + Environment.NewLine +
                                 "    ##" + Environment.NewLine +
                                 "   ###" + Environment.NewLine +
                                 "  ####" + Environment.NewLine +
                                 " #####" + Environment.NewLine +
                                 "######" + Environment.NewLine;

            var result = _staircase.solution(6);
            
            Assert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
