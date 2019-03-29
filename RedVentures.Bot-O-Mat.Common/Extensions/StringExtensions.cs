namespace CommonPatterns.Extensions
{
    /// <summary>
    /// Will return null is string passed is empty. Usefull for null coallesence: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
    /// </summary>
    /// <example>string someProperty = className.aStringProperty.IsNullOrEmpty() ? "my other string" : className.aStringProperty</example>
    /// <example>string someProperty = className.aStringProperty.NullIfEmpty() ?? "my other string"</example>
    public static class StringExtensions
    {
        public static string NullIfEmpty(this string stringValue) => string.IsNullOrEmpty(stringValue) ? null : stringValue;
    }
}
