using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03
{
    public static class Extensions
    {
        public static IEnumerable<(int a, int b)> Parse(this string line) =>
            Regex.Matches(line, @"(mul\((?<a>\d+)\,(?<b>\d+)\))")
            .Select(match => (int.Parse(match.Groups["a"].Value), int.Parse(match.Groups["b"].Value)));
    }
}
