using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Strings;

namespace Tests.Strings
{
    [TestClass]
    public class CamelCaseTest
    {
        private CamelCase _camelCase;

        [TestInitialize]
        public void Initialize()
        {
            _camelCase = new CamelCase();
        }

        [TestMethod]
        public void CamelCase_Example_Test_1()
        {
            var input = "saveChangesInTheEditor";

            var result = _camelCase.solution(input); 

            Assert.AreEqual(5, result);
        }
       
    }
}
