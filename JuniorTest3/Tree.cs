using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorTest3
{
    public class Tree
    {
        public string Name { get; set; }

        public IEnumerable<Tree> Children { get; set; } = new List<Tree>();
        
        public static List<Tree> GetAllChildren(Tree tree)
        {
            List<Tree> childrens = new List<Tree>();
            foreach (var child in tree.Children)
            {
                childrens.Add(child);
                childrens.AddRange(GetAllChildren(child));
            }
            return childrens;
        }
    }
}
