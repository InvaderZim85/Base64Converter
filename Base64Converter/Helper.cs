using System;
using System.Text;

namespace Base64Converter
{
    /// <summary>
    /// Provides several helper functions
    /// </summary>
    internal static class Helper
    {
        /// <summary>
        /// Converts a plain text into a Base64 coded string
        /// </summary>
        /// <param name="value">The plain text</param>
        /// <returns>The Base64 encoded string</returns>
        public static string ToBase64String(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            var bytes = Encoding.UTF8.GetBytes(value);

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Converts a Base 64 encoded string into plain text
        /// </summary>
        /// <param name="value">The Base64 encoded string</param>
        /// <returns>The plain text</returns>
        public static string ToPlainText(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            var bytes = Convert.FromBase64String(value);

            return Encoding.UTF8.GetString(bytes);
        }
    }
}
