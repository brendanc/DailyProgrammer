using System.Collections.Generic;

namespace DailyProgramer.Permutations
{
    public class Combination
    {
        private int factor;
        private int size;

        public Combination(int factor,int size)
        {
            this.factor = factor;
            this.size = size;
        }

        public IEnumerable<string> GenerateTree()
        {
            var perm = new Permutation(factor);
            var ptree =perm.GenerateTree();
            var tree = new SortedSet<string>();
            foreach (var p in ptree)
            {
                tree.Add(p.Substring(0, size));
            }

            return ptree;
        }
    }
}
