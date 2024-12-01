using System.Text.RegularExpressions;

namespace AdventOfCode2024
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var solution = new Solution("input.txt");
            
            Console.WriteLine($"start 1: {solution.Star1()}");
            
            Console.WriteLine($"start 2: {solution.Star2()}");
        }
    }
}
