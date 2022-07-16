using System;
using System.Collections.Generic;
namespace JuniorTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree() { Name = "t1" };
            Tree t2 = new Tree() { Name = "t2" };
            Tree t3 = new Tree() { Name = "t3", Children = new List<Tree>() { t1, t2 } };        
            Tree t4 = new Tree() { Name = "t4" };
            Tree t5 = new Tree() { Name = "t5", Children = new List<Tree>() { t3, t4 } };

            foreach (var tree in Tree.GetAllChildren(t3))
            {
                Console.WriteLine(tree.Name);
            }

            Console.WriteLine("");

            foreach (var tree in Tree.GetAllChildren(t5))
            {
                Console.WriteLine(tree.Name);
            }
        }
        
    }
}
