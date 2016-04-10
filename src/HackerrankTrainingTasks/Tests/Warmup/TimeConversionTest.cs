using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class TimeConversionTest
    {
        private TimeConversion _timeConversion;

        [TestInitialize]
        public void Initialize()
        {
            _timeConversion = new TimeConversion();
        }

        #region Example Tests

        [TestMethod]
        public void TimeConversion_Example_Test()
        {
            var expectedResult = "19:05:45";

            var result = _timeConversion.solution("07:05:45PM");
            
            Assert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
