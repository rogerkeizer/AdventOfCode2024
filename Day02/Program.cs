namespace AdventOfCode2024.Day02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var solution = new Solution("input.txt");

            Console.WriteLine($"star 1: {solution.Star1()}");

            Console.WriteLine($"star 2: {solution.Star2()}");
        }
    }
}
