using System;
using Adapters.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtWebPageAnalyzer.Helpers
{
    [TestClass]
    public class UtUrlHelper
    {
        const string InvalidUrl = "invalidurl";
        const string ValidUrl = @"http://rogowowakacje.pl/";
        const string NullUrl = null;


        [TestMethod]
        public void IsValid_ValidUrl_ReturnTrue()
        {
            var isValidUrl = UrlHelper.IsValid(ValidUrl);
            Assert.IsTrue(isValidUrl);
        }

        [TestMethod]
        public void IsValid_InvalidUrl_ReturnFalse()
        {
            var isValidUrl = UrlHelper.IsValid(InvalidUrl);
            Assert.IsFalse(isValidUrl);
        }

        [TestMethod]
        public void IsValid_NullUrl_ThrowsException()
        {
            try
            {
                var isValidUrl = UrlHelper.IsValid(NullUrl);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }
    }
}
