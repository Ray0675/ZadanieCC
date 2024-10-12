using System.Collections.Generic;
using ZadanieCC.objects;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Point p1 = new(1, 1, 1);
        Console.WriteLine(p1.ToString() + "\n");
        Vector v1 = new(p1);
        Console.WriteLine(v1.ToString() + "\n");
        Vector v2 = (Vector)v1.Clone();
        Console.WriteLine(v2.ToString() + "\n");
        Vector v3 = new(v1.AngleXY(), v1.AngleXZ(), v1.Length());
        Console.WriteLine(v3.ToString() + "\n");
        */

        List<Vector> vectors = new() { new Vector(new Point(1, 5, 1)), new Vector(new Point(2, 8, 2)), new Vector(new Point(3, 5, 3)), new Vector(new Point(4, 4, 1)), new Vector(new Point(1, 3, 1)) };
        CompareOp VectorsCompare = new CompareOp(Vector.LhsIsGreater);

        Console.WriteLine(string.Join("\n\n", vectors));
        Console.WriteLine("-------------");
        BubbleSorter<Vector>.Sort(vectors, VectorsCompare);
        Console.WriteLine(string.Join("\n\n", vectors));
    }
}

namespace ZadanieCC.objects 
{
    public delegate bool CompareOp(object lhs, object rhs);
}