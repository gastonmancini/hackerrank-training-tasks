using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class IntroToTutorialChallengesTest
    {
        private IntroToTutorialChallenges _introToTutorialChallenges;

        [TestInitialize]
        public void Initialize()
        {
            _introToTutorialChallenges = new IntroToTutorialChallenges();
        }

        #region Example Tests

        [TestMethod]
        public void IntroToTutorialChallenges_Example_Test_1()
        {
            var arr = new [] {1, 4, 5, 7, 9, 12};

            Assert.AreEqual(1, _introToTutorialChallenges.solution(arr, 4));
        }

        #endregion

        #region Extremes tests

        [TestMethod]
        public void IntroToTutorialChallenges_OneElementArray_FirstElement()
        {
            var arr = new[] { 5 };

            Assert.AreEqual(0, _introToTutorialChallenges.solution(arr, 4));
        }

        [TestMethod]
        public void IntroToTutorialChallenges_OneElementArray_LastElement()
        {
            var arr = new[] { 5 };

            Assert.AreEqual(1, _introToTutorialChallenges.solution(arr, 6));
        }

        [TestMethod]
        public void IntroToTutorialChallenges_EmptyArray()
        {
            var arr = new int[] { };

            Assert.AreEqual(0, _introToTutorialChallenges.solution(arr, 6));
        }

        #endregion
    }
}
