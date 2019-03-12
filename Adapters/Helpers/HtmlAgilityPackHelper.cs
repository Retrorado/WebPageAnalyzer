using HtmlAgilityPack;

namespace Adapters.Helpers
{
    /// <summary>
    /// Helper class that provides methods for HtmlAgilityPack
    /// </summary>
    public static class HtmlAgilityPackHelper
    {
        #region Public static methods

        /// <summary>
        /// Gets an html document from url
        /// </summary>
        /// <param name="webpageUrl"></param>
        /// <returns></returns>
        public static HtmlDocument RetrieveHtml(string webpageUrl)
        {
            var htmlWeb = new HtmlWeb();
            return htmlWeb.Load(webpageUrl);
        }

        /// <summary>
        /// Gets all nodes from html document
        /// </summary>
        /// <param name="htmlDocument">Html document</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetMetaNodesCollection(HtmlDocument htmlDocument)
        {
            return htmlDocument.DocumentNode.SelectNodes("//meta");
        }

        #endregion
    }
}
