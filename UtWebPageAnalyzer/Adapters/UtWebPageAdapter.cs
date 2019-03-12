using System.Collections.Generic;
using System.Linq;
using Adapters;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtWebPageAnalyzer.Adapters
{
    [TestClass()]
    public class UtWebPageAdapter
    {
        const string invalidUrl = "invalidurl";
        const string validUrl = @"http://rogowowakacje.pl/";
        private IWebPageAdapter _testObject;

        [TestMethod()]
        public void IsUrlValid_InvalidUrl_ReturnFalse()
        {
            _testObject = new WebPageAdapter();
            var isUrlValid = _testObject.IsUrlValid(invalidUrl);
            Assert.IsFalse(isUrlValid);
        }

        [TestMethod()]
        public void IsUrlValid_ValidUrl_ReturnTrue()
        {
            _testObject = new WebPageAdapter();
            var isUrlValid = _testObject.IsUrlValid(validUrl);
            Assert.IsTrue(isUrlValid);
        }

        [TestMethod()]
        public void GetKeywords_InvalidUrl_ReturnNull()
        {
            _testObject = new WebPageAdapter();
            var keywords = _testObject.GetKeywords(invalidUrl);
            Assert.IsTrue(keywords == null);
        }

        [TestMethod()]
        public void GetKeywords_ValidUrl_ReturnKeywords()
        {
            _testObject = new WebPageAdapter();
            var keywords = _testObject.GetKeywords(validUrl);
            Assert.IsTrue(keywords.Count > 0);
        }

        [TestMethod()]
        public void GetKeywordOccurrences_ValidUrlAndInvalidKeyword_ReturnZero()
        {
            var searchedKeyword = "wakacje Kolobrzeg";
            var expectedKeywordOccurrences = 0;
            _testObject = new WebPageAdapter();
            var keywordOccurrences = _testObject.GetKeywordOccurrences(searchedKeyword, validUrl);
            Assert.IsTrue(keywordOccurrences == expectedKeywordOccurrences);
        }

        [TestMethod()]
        public void GetKeywordOccurrences_ValidUrlAndKeyword_ReturnNumberOfOccurrence()
        {
            var searchedKeyword = "wakacje Rogowo";
            var expectedKeywordOccurrences = 3;
            _testObject = new WebPageAdapter();
            var keywordOccurrences = _testObject.GetKeywordOccurrences(searchedKeyword, validUrl);
            Assert.IsTrue(keywordOccurrences == expectedKeywordOccurrences);
        }

        [TestMethod()]
        public void GetKeywordOccurrences_InValidUrl_ReturnZero()
        {
            var searchedKeyword = "wakacje Rogowo";
            var expectedKeywordOccurrences = 0;
            _testObject = new WebPageAdapter();
            var keywordOccurrences = _testObject.GetKeywordOccurrences(searchedKeyword, invalidUrl);
            Assert.IsTrue(keywordOccurrences == expectedKeywordOccurrences);
        }

        [TestMethod()]
        public void GetKeywordsOccurrences_ValidUrl_ReturnListOfKeywordDtoWithOccurrences()
        {
            var searchedKeywords = new List<string>();
            searchedKeywords.Add("wakacje Rogowo");
            searchedKeywords.Add("wakacje nad morzem");
            _testObject = new WebPageAdapter();
            var keywordOccurrences = _testObject.GetKeywordsOccurrences(searchedKeywords, validUrl);
            Assert.IsTrue(keywordOccurrences.Count > 0);
            Assert.IsTrue(keywordOccurrences.Any(keyword => keyword.OccurenceCount > 0));
        }

        [TestMethod()]
        public void GetKeywordsOccurrences_InvalidUrl_ReturnNull()
        {
            var searchedKeywords = new List<string>();
            searchedKeywords.Add("wakacje Rogowo");
            searchedKeywords.Add("wakacje nad morzem");
            _testObject = new WebPageAdapter();
            var keywordOccurrences = _testObject.GetKeywordsOccurrences(searchedKeywords, invalidUrl);
            Assert.IsTrue(keywordOccurrences == null);
        }
    }
}

