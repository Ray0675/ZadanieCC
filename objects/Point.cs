namespace ZadanieCC.objects;
public class Point : IObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point (double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
    }
    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
    }
    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
    }
    public override string ToString()
    {
        return $"X:{X} Y:{Y} Z:{Z}";
    }
    public object Clone()
    {
        return (Point)(new(X, Y, Z)); 
    }
}

