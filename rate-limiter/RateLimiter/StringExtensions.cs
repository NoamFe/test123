namespace RateLimiter;

public static class StringExtensions
{
    public static bool IsUSToken(this string str) => str.StartsWith("US-");
}