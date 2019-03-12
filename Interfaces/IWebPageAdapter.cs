using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    /// <summary>
    /// Interface provides functions to handle operations with web page
    /// </summary>
    public interface IWebPageAdapter
    {
        /// <summary>
        /// Checks if url is valid
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns>True if url is valid, false otherwise</returns>
        bool IsUrlValid(string url);

        /// <summary>
        /// Gets all keywords from web page.
        /// </summary>
        /// <param name="url">Web page url</param>
        /// <returns>List of keywords</returns>
        List<string> GetKeywords(string url);

        /// <summary>
        /// Finds all occurrences of keyword in web page from url.
        /// </summary>
        /// <param name="keyword">Keyword</param>
        /// <param name="url">Web page url</param>
        /// <returns>Number of keyword occurrences</returns>
        int GetKeywordOccurrences(string keyword, string url);

        /// <summary>
        /// Finds all occurrences of all keywords in web page HTML document.
        /// </summary>
        /// <param name="keywords">List of keywords</param>
        /// <param name="url">Web page url</param>
        /// <returns>List of objects KeywordDto containing all keywords with number of occurrences</returns>
        List<KeywordDto> GetKeywordsOccurrences(IEnumerable<string> keywords, string url);
    }
}
