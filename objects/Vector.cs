namespace ZadanieCC.objects;

public class Vector : IObject
{
    public Point Point;

    public Vector(Point point)
    {
        Point = new(point.X, point.Y, point.Z);
    }

    public Vector(double angleXY, double angleXZ, double length) 
    {
        double angleXYInRadians = angleXY * (Math.PI / 180.0);
        double angleXZInRadians = angleXZ * (Math.PI / 180.0);
        Point = new Point(length * Math.Cos(angleXZInRadians) * Math.Cos(angleXYInRadians), length * Math.Cos(angleXZInRadians) * Math.Sin(angleXYInRadians), length * Math.Sin(angleXZInRadians));
    }
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.Point.X + v2.Point.X, v1.Point.Y + v2.Point.Y, v1.Point.Z + v2.Point.Z);
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.Point.X - v2.Point.X, v1.Point.Y - v2.Point.Y, v1.Point.Z - v2.Point.Z);
    }
    public static Vector operator *(Vector v1, Vector v2)
    {
        return new Vector(v1.Point.X * v2.Point.X, v1.Point.Y * v2.Point.Y, v1.Point.Z * v2.Point.Z);
    }
    public static Vector operator /(Vector v1, Vector v2)
    {
        return new Vector(v1.Point.X / v2.Point.X, v1.Point.Y / v2.Point.Y, v1.Point.Z / v2.Point.Z);
    }
    public double Length() 
    {
        return Math.Sqrt(Point.X * Point.X + Point.Y * Point.Y + Point.Z * Point.Z);
    }
    public double AngleXY()
    {
        return Math.Atan2(Point.Z, Math.Sqrt(Point.X * Point.X + Point.Y * Point.Y)) * (180.0 / Math.PI);
    }
    public double AngleXZ()
    {
        return Math.Atan2(Point.Y, Math.Sqrt(Point.X * Point.X + Point.Z * Point.Z)) * (180.0 / Math.PI);
    }
    public override string ToString()
    {
        return $"Координаты X:{Point.X} Y:{Point.Y}\n" +
            $"Длина: {Length()}\n" +
            $"Угол наклона на плоскости XY: {AngleXY()}\n" +
            $"Угол наклона на плоскости XZ: {AngleXZ()}";
    }
    public object Clone()
    {
        return (Vector)new(Point);
    }

    public static bool LhsIsGreater(object lhs, object rhs) 
    {
        Vector lhsV = (Vector)lhs;
        Vector rhsV = (Vector)rhs;
        return lhsV.Length() > rhsV.Length();
    }
}
