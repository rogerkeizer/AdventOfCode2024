namespace AdventOfCode2024.Day03
{
    public class Solution(string file)
    {
        public int Star1()
        {
            var list = File.ReadAllLines(file).SelectMany(Extensions.Parse).ToList();

            var muls = 0;

            foreach (var (a, b) in list)
            {
                muls += a * b;
            }

            return muls;
        }

        public int Star2()
        {
            return 0;
        }
    }
}