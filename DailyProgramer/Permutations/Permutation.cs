using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramer.Permutations
{
    public class Permutation
    {
        private int factor;


        public Permutation(int factor)
        {
            if (factor < 2) throw new ArgumentOutOfRangeException();
            this.factor = factor;
        }

        public IEnumerable<string> GenerateTree()
        {
            var tree = new SortedSet<string>();
            var factorial = Factorial(factor);
            var numbers = new List<int>();

            for(var i = 0; i < factor; i++)
            {
                numbers.Add(i);
            }
         
           var random = new Random();
           while (tree.Count < factorial)
           {
                var number = string.Join("", numbers.OrderBy(x => random.Next()).ToArray());
                tree.Add(number);
           }
            return tree;
        }


        private int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}
