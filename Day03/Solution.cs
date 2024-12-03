using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03
{
    public class Solution(string file)
    {
        public int Star1()
        {
            var muls = 0;

            var pattern = @"([0-9]+)+";

            var rg = new Regex(pattern);

            var input = ParseInput(file);

            foreach(var l in input)
            {
                var matches = rg.Matches(l);

                var multiplication = matches.AsEnumerable().Select(m=>m.Value).ToList();

                muls += Convert.ToInt32(multiplication[0]) * Convert.ToInt32(multiplication[1]);
                
            }

            return muls;
        }

        public int Star2()
        {
            return 0;
        }

        private static List<string> ParseInput(string file)
        {
            var pattern = @"(mul\(([0-9]+)\,([0-9]+)\))";

            var rg = new Regex(pattern);

            var f = File.ReadAllText(file);

            MatchCollection matches = rg.Matches(f);

            return matches.AsEnumerable().Select(m => m.Value).ToList();
        }
    }
}