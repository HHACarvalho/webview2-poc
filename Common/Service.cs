using System;

namespace Common
{
    /// <summary>
    /// Given a string returns a valid URI.
    /// </summary>
    /// <param name="rawUrl">The URL or seach query in string form.</param>
    /// <returns>Returns a valid URI if the string provided was either valid or incomplete. Returns a google search result otherwise.</returns>
    public static class Service
    {
        public static Uri GetValidUri(string rawUrl)
        {
            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                return new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                return new Uri("https://" + rawUrl);
            }
            else
            {
                return new Uri("https://google.com/search?q=" + string.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }
        }
    }
}
