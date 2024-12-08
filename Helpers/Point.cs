namespace Helpers;

public record struct Point(int x, int y)
{
    public static implicit operator Point((int x, int y) tuple) => new (tuple.x, tuple.y);

    public static Point operator +(Point a, Point b) => new(a.x + b.x, a.y + b.y);

    public static Point operator -(Point a, Point b) => new(a.x - b.x, a.y - b.y);

    public static Point operator *(Point p, int many) => new(p.x * many, p.y * many);
}
