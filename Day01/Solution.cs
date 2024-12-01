using System.Text.RegularExpressions;

namespace AdventOfCode2024
{
    public class Solution(string file)
    {
        public int Star1()
        {
            var star1 = 0;
            
            var input = ParseInput(file);
          
            for(int i=0; i< input.left.Count; i++)
            {
                star1 += Math.Abs(input.left[i] - input.right[i]);
            }
        
            return star1;
        }
        
        public int Star2()
        {
            var star2 = 0;
            
            var input = ParseInput(file);
            
            for (int i = 0; i < input.left.Count; i++)
            {
                int n = input.left[i];
                star2 += n * input.right.Count(x => x == n);
            }
            
            return star2;
        }
        
        static ParseResult ParseInput(string file)
        {
            List<int> left = new();
            List<int> right = new();
            
            using StreamReader reader = new(file);
    
            while (reader != null && !reader.EndOfStream)
            {
                var r = reader.ReadLine();
    
                if (r != null)
                {
                    string[] numbers = Regex.Split(r, @"\D+");
                    
                    left.Add(Convert.ToInt32(numbers[0]));
                    
                    right.Add(Convert.ToInt32(numbers[1]));
                }
            }
            
            left.Sort();
            
            right.Sort();
            
            return new ParseResult() {
                left = left,
                right = right
            };
        }
    }
}