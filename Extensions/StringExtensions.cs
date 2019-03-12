using System;

namespace Extensions
{
    /// <summary>
    /// Class that provide extension methods for string
    /// </summary>
    public static class StringExtensions
    {
        #region Extensions methods

        /// <summary>
        /// Gets number of occurrences given text in string
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="value">Searched text</param>
        public static int OccurrencesOf(this string str, string value)
        {
            var occurrences = 0;
            if (string.IsNullOrEmpty(value))
                return occurrences;

            for (var index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index, StringComparison.Ordinal);
                if (index == -1)
                    return occurrences;
                occurrences++;
            }
        }

        #endregion
    }
}
