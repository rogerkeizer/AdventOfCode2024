using Helpers;

namespace Day04;

public class Solution(string file)
{
    private int _width = 0;
    private int _height = 0;

    private char[,] _map;

    public int Star1()
    {
        var word = "XMAS";
        
        var lines = ParseInput(file);

        _map = ConvertToMap(lines);

        int star1 = 0;

        for(var x = 0; x < _width; x++)
        {
            for (var y = 0; y < _height; y ++)
            {
                for(var i = 0; i < Directions.WithDiagonals.Length; i++)
                {
                    var d = Directions.WithDiagonals[i];

                    if(FindWord((x,y), d, word))
                    {
                        star1 ++;
                    }
                }
            }
        }

        return star1;
    }

    public int Star2()
    {
        return 0;
    }

    private bool FindWord(Point start, Point dir, string word)
    {
        for (var i = 0; i< word.Length; i++ )
        {
            var p = start + dir * i;

            if(p.x < 0 ||
            p.x >= _width ||
            p.y < 0 ||
            p.y >= _height ||
            _map[p.x, p.y] != word[i])
            {
                return false;
            }
        }
        return true;
    }
    private List<string> ParseInput(string file)
    {
        List<string> lines = new();

        using StreamReader reader = new(file);

        while(reader.ReadLine() is {} line)
        {
            _width = line.Length;
            lines.Add(line);
            _height++;
        }
        
        return lines;
    }

    private char[,] ConvertToMap(List<string> lines)
    {
        var map = new char[_width, _height];

        for(var y =0 ; y < _height; y++)
        {
            for(var x = 0; x <_width; x++)
            {
                map[x,y] = lines[y][x];
            }
        }

        return map;
    }
}