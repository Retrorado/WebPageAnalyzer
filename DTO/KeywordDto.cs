using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// DTO for word usages
    /// </summary>
    public class KeywordDto
    {
        #region Properties

        /// <summary>
        /// Searched keyword
        /// </summary>
        [DisplayName("Keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// Number of occurrence of the keyword
        /// </summary>
        [DisplayName("Number of occurrence")]
        public int OccurenceCount { get; set; }

        #endregion

        #region Constructos

        public KeywordDto()
        {

        }

        public KeywordDto(string keyword, int occurrenceCount)
        {
            Keyword = keyword;
            OccurenceCount = occurrenceCount;
        }


        #endregion
    }

}
