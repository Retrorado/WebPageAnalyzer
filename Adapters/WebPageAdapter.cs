using Adapters.Helpers;
using DTO;
using Extensions;
using HtmlAgilityPack;
using Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace Adapters
{
    /// <inheritdoc />
    /// <summary>
    /// Class that implements methods from IWebPageAdapter
    /// </summary>
    public class WebPageAdapter : IWebPageAdapter
    {
        #region IWebPageAdapter implementation

        public bool IsUrlValid(string url)
        {
            return CheckIfUrlIsValid(url);
        }

        public List<string> GetKeywords(string url)
        {
            return GetKeywordsFromUrl(url);
        }

        public int GetKeywordOccurrences(string keyword, string url)
        {
            return GetKeywordOccurrencesFromHtmlDocument(keyword, url);
        }

        public List<KeywordDto> GetKeywordsOccurrences(IEnumerable<string> keywords, string url)
        {
            return GetKeywordsOccurrencesFromHtmlDocument(keywords, url);
        }

        #endregion

        #region Private methods

        private bool CheckIfUrlIsValid(string url)
        {
            return UrlHelper.IsValid(url);
        }

        private List<string> GetKeywordsFromUrl(string url)
        {
            if (!IsUrlValid(url)) return null;

            var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(url);
            var metaNodes = HtmlAgilityPackHelper.GetMetaNodesCollection(htmlDocument);
            return GetKeywordsFromMetaNodes(metaNodes);
        }

        private List<string> GetKeywordsFromMetaNodes(HtmlNodeCollection metaNodes)
        {
            var keywords = new List<string>();

            if (metaNodes == null) return keywords;

            foreach (var tag in metaNodes)
            {
                var tagName = tag.Attributes["name"];
                var tagNameValue = "keywords";
                var tagContent = tag.Attributes["content"];

                if (tagName == null || !tagName.Value.ToLower().Equals(tagNameValue) || tagContent == null)
                    continue;

                var tagContentValues = TextHelper.SplitString(tagContent.Value, ',');
                keywords.AddRange(tagContentValues);
                break;
            }

            return keywords;
        }

        private int GetKeywordOccurrencesFromHtmlDocument(string keyword, string url)
        {
            if (!IsUrlValid(url)) return 0;

            var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(url);
            return htmlDocument.Text.OccurrencesOf(keyword);
        }

        private List<KeywordDto> GetKeywordsOccurrencesFromHtmlDocument(IEnumerable<string> keywords, string url)
        {
            if (!IsUrlValid(url)) return null;

            var htmlDocument = HtmlAgilityPackHelper.RetrieveHtml(url);
            return (from keyword in keywords
                    let occurrenceCount = htmlDocument.Text.OccurrencesOf(keyword)
                    select new KeywordDto()
                    {
                        Keyword = keyword,
                        OccurenceCount = occurrenceCount
                    }).ToList();
        }

        #endregion
    }
}
