namespace Demo;

public static class StringExtensions
{
    /// <summary>
    /// Returns a Base64 encoding of a UTF8-encoded string.
    /// </summary>
    public static string Base64Encode(this string value)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
    }

    /// <summary>
    /// Decodes a Base64 string and interprets the result as a UTF8-encoded string.
    /// </summary>
    public static string Base64Decode(this string value)
    {
        return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value));
    }
}