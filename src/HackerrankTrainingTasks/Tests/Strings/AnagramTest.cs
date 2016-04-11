using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class AnagramTest
    {
        private Anagram _anagram;

        [TestInitialize]
        public void Initialize()
        {
            _anagram = new Anagram();
        }

        #region Example Tests

        [TestMethod]
        public void Anagram_Example_Test_1()
        {
            Assert.AreEqual(3, _anagram.solution("aaabbb"));
        }

        [TestMethod]
        public void Anagram_Example_Test_2()
        {
            Assert.AreEqual(1, _anagram.solution("ab"));
        }

        [TestMethod]
        public void Anagram_Example_Test_3()
        {
            Assert.AreEqual(-1, _anagram.solution("abc"));
        }

        [TestMethod]
        public void Anagram_Example_Test_4()
        {
            Assert.AreEqual(2, _anagram.solution("mnop"));
        }

        [TestMethod]
        public void Anagram_Example_Test_5()
        {
            Assert.AreEqual(0, _anagram.solution("xyyx"));
        }

        [TestMethod]
        public void Anagram_Example_Test_6()
        {
            Assert.AreEqual(1, _anagram.solution("xaxbbbxx"));
        }

        [TestMethod]
        public void Anagram_Example_Test_7()
        {
            Assert.AreEqual(-1, _anagram.solution("ahrlclerknxtwayoiqbrpfdemcxqmvhmcbzgmdayqxsnasdkigcznfdajcsvycjadijrmjqeiktieztohxnvesvnvpktrtvwbeqppiwyuriyqdmyazterqtmhdhzwdxahnrzv"));
        }

        [TestMethod]
        public void Anagram_Example_Test_8()
        {
            Assert.AreEqual(-1, _anagram.solution("xphhpxlbxlassuklisrqtpvqpcgjddyavfkkfvmci"));
        }

        [TestMethod]
        public void Anagram_Example_Test_9()
        {
            Assert.AreEqual(23, _anagram.solution("vakhotzflsuglmkrxowvqrbaegxskgghgrpwmodzjafwornlhlgydjajrybeehlmaajoroncouyconnvywtdfumzsndyxokzrvqkkfoaamdqbslzoffwbtvvjatiqfhjbztnfjnhvsxwliyzpfxqyunjuirnobwrasehbtozmlvxuvylawebsr"));
        }

        [TestMethod]
        public void Anagram_Example_Test_10()
        {
            Assert.AreEqual(13, _anagram.solution("paecqhyjhsnpuifvurqtnosyqqctkwgzykborcxawmrswxnrogmdugbkygejckiawmopqnpmbjhxguqwadbu"));
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
