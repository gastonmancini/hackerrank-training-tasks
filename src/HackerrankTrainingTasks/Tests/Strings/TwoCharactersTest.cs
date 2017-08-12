using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class TwoCharactersTest
    {
        private TwoCharacters _twoCharacters;

        [TestInitialize]
        public void Initialize()
        {
            _twoCharacters = new TwoCharacters();
        }

        [TestMethod]
        public void TwoCharacters_Example_Test_1()
        {
            Assert.AreEqual(5, _twoCharacters.solution(10, "beabeefeab"));
        }

        [TestMethod]
        public void TwoCharacters_Example_Test_2()
        {
            Assert.AreEqual(0, _twoCharacters.solution(375, "uyetuppelecblwipdsqabzsvyfaezeqhpnalahnpkdbhzjglcuqfjnzpmbwprelbayyzovkhacgrglrdpmvaexkgertilnfooeazvulykxypsxicofnbyivkthovpjzhpohdhuebazlukfhaavfsssuupbyjqdxwwqlicbjirirspqhxomjdzswtsogugmbnslcalcfaxqmionsxdgpkotffycphsewyqvhqcwlufekxwoiudxjixchfqlavjwhaennkmfsdhigyeifnoskjbzgzggsmshdhzagpznkbahixqgrdnmlzogprctjggsujmqzqknvcuvdinesbwpirfasnvfjqceyrkknyvdritcfyowsgfrevzon"));
        }
    }
}
