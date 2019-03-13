using System;
using System.Linq;
using Adapters.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtWebPageAnalyzer.Helpers
{
    [TestClass]
    public class UtTextHelper
    {
        const string EmptyString = "";
        const string ValidString = "one,two,three";
        const string NullString = null;


        [TestMethod]
        public void SplitString_ValidString_ReturnListOfString()
        {
            var listOfKeywords = TextHelper.SplitString(ValidString, ',');
            Assert.IsNotNull(listOfKeywords);
            Assert.IsTrue(listOfKeywords.Count > 0);
        }

        [TestMethod]
        public void SplitString_InValidString_ReturnEmptyList()
        {
            var listOfKeywords = TextHelper.SplitString(EmptyString, ',');
            Assert.IsNotNull(listOfKeywords);
            Assert.IsTrue(listOfKeywords.Count == 1);
            Assert.IsTrue(listOfKeywords.FirstOrDefault() == EmptyString);
        }

        [TestMethod]
        public void SplitString_NullString_ThrowsException()
        {
            try
            {
                var listOfKeywords = TextHelper.SplitString(NullString, ',');
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }
    }
}
