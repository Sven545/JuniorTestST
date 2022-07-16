using System;

namespace JuniorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;
            Console.WriteLine($"x={x},y={y},z={z}");
            Swap(ref x, ref y, ref z);
            Console.WriteLine($"x={x},y={y},z={z}");
        }
        static void Swap(ref int x,ref int y,ref int z)
        {
            (x, y, z) = (y, z, x);
        }
    }
}
