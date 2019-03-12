using System.Collections.Generic;
using System.Linq;

namespace Adapters.Helpers
{
    /// <summary>
    /// Helper class that provides methods for text operations
    /// </summary>
    public static class TextHelper
    {
        #region Public static methods

        /// <summary>
        /// Splits string by separator and return list of strings
        /// </summary>
        /// <param name="text"></param>
        /// <param name="separator"></param>
        public static List<string> SplitString(string text, char separator)
        {
            return text.Split(separator).ToList();
        }

        #endregion
    }
}
