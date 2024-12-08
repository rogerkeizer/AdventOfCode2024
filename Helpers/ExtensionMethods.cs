namespace Helpers;

public static class ExtensionMethods
{

/// <summary>
/// Returns the input typed as a generic IEnumerable of the matches
/// </summary>
/// <param name="mc"></param>
/// <returns></returns>
    public static IEnumerable<System.Text.RegularExpressions.Match> AsEnumerable(this System.Text.RegularExpressions.MatchCollection mc)
    {
        foreach (System.Text.RegularExpressions.Match m in mc)
        {
            yield return m;
        }
    }
}