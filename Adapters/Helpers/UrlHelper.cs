using System;

namespace Adapters.Helpers
{
    /// <summary>
    /// Helper class that provides methods for operations concerning Url
    /// </summary>
    public static class UrlHelper
    {
        #region Public static methods

        /// <summary>
        /// Checks if url is valid.
        /// </summary>
        /// <param name="url">Url</param>
        public static bool IsValid(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        #endregion
    }
}
