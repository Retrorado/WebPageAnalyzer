using Adapters.Helpers;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UtWebPageAnalyzer.Helpers
{
    [TestClass]
    public class UtHtmlAgilityPackHelper
    {
        const string InvalidUrl = "invalidurl";
        const string ValidUrl = @"http://rogowowakacje.pl/";


        [TestMethod]
        public void RetrieveHtml_ValidUrl_ReturnHtmlDocument()
        {
            var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(ValidUrl);
            Assert.IsNotNull(htmlDocument);
        }

        [TestMethod]
        public void RetrieveHtml_InvalidUrl_ThrowsException()
        {
            try
            {
                var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(InvalidUrl);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        [TestMethod]
        public void GetMetaNodesCollection_ValidHtml_ReturnHtmlNodeCollection()
        {
            var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(ValidUrl);
            var nodeCollection = HtmlAgilityPackHelper.GetMetaNodesCollection(htmlDocument);
            Assert.IsNotNull(nodeCollection);
        }

        [TestMethod]
        public void GetMetaNodesCollection_InvalidHtml_ReturnNull()
        {
            var htmlDocument = new HtmlDocument();
            var nodeCollection = HtmlAgilityPackHelper.GetMetaNodesCollection(htmlDocument);
            Assert.IsNull(nodeCollection);
        }
    }
}
