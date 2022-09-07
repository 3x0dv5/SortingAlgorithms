using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace xTest.SortingAlgorithms;

public static class Assertions
{
    public static void EqualString(string actual, string expected, ITestOutputHelper output)
    {
        try
        {
            Assert.Equal(expected.TrimLines().ReplaceLineEndings(), actual.TrimLines().ReplaceLineEndings());
        }
        catch (Exception e)
        {
            output.WriteLine($"Actual: \n\n{actual}\n\n\n\n.");
            output.WriteLine($"\n\nExpected: \n\n{expected}");
            throw;
        }
    }

    public static string TrimLines(this string query)
    {
        var q = query.SplitLines();
        return string.Join(' ', q.Select(m => m.Trim()).Where(m => !string.IsNullOrEmpty(m)));
    }

    public static string[] SplitLines(this string str)
    {
        return Regex.Split(str, "\r\n|\r|\n");
    }
}