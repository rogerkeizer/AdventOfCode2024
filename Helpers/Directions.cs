namespace Helpers;

public static class Directions
{
    public static Point[] Diagonals {get; } = [
        (1,1),
        (-1,1),
        (1,-1),
        (-1,-1)
    ];

    public static Point[] WithoutDiagonals {get; } = [
        (0,1),
        (1,0),
        (0,-1),
        (-1,0)
    ];

    public static Point[] WithDiagonals {get; } = [
        (0,1),
        (1,0),
        (0,-1),
        (-1,0),
        (1,1),
        (-1,1),
        (1,-1),
        (-1,-1)
    ];

}