using System.Text.RegularExpressions;

namespace Day02;
public class Solution(string file)
{
    public int Star1()
    {
        return DetectSaveReports(ParseInput(file));
    }

    public int Star2()
    {
        List<List<int>> problemDamper = new();

        var input = ParseInput(file);

        var saveReports = input.Count;

        foreach (var l in input)
        {
            var prevStep = 0;

            for (int i = 0; i < l.Count; i++)
            {
                if (i + 1 < l.Count)
                {
                    var step = l[i] - l[i + 1];

                    if ((step >= -3 && step <= 3) && (step != 0))
                    {
                        if (i > 0 && (Math.Sign(prevStep) != Math.Sign(step)))
                        {
                            saveReports--;

                            saveReports += CheckByProblemDamper(l);

                            break;
                        }
                        else
                        {
                            prevStep = step;
                        }
                    }
                    else
                    {
                        saveReports--;

                        saveReports += CheckByProblemDamper(l);

                        break;
                    }
                }
            }
        }

        saveReports += DetectSaveReports(problemDamper);


        return saveReports;
    }

    private static int DetectSaveReports(List<List<int>> input)
    {
        var reports = input.Count;

        foreach (var l in input)
        {
            var prevStep = 0;

            for (int i = 0; i < l.Count; i++)
            {
                if (i + 1 < l.Count)
                {
                    var step = l[i] - l[i + 1];

                    if ((step >= -3 && step <= 3) && (step != 0))
                    {
                        if (i > 0 && (Math.Sign(prevStep) != Math.Sign(step)))
                        {
                            reports--;

                            break;
                        }
                        else
                        {
                            prevStep = step;
                        }
                    }
                    else
                    {
                        reports--;

                        break;
                    }
                }
            }
        }

        return reports;
    }

    private static int CheckByProblemDamper(List<int> l)
    {
        var problemDamper = new List<List<int>>();

        var x = l.Count;

        for (var y = 0; y < l.Count; y++)
        {
            var temp = new List<int>(l);

            temp.RemoveAt(x - 1);

            problemDamper.Add(temp);

            x--;
        }

        var result = DetectSaveReports(problemDamper);

        return (result >= 1) ? 1 : 0;

    }

    private static List<List<int>> ParseInput(string file)
    {
        List<List<int>> input = new();

        using StreamReader reader = new(file);

        while (reader != null && !reader.EndOfStream)
        {
            var r = reader.ReadLine();

            if (r != null)
            {
                string[] numbers = Regex.Split(r, @"\D+");

                var list = new List<int>();

                foreach (var n in numbers)
                {
                    list.Add(Convert.ToInt32(n));
                }

                input.Add(list);
            }
        }

        return input;
    }
}