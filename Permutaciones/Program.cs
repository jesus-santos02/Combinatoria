using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputSet = { 'A', 'A', 'C' };

            Permutations<char> P1 = new Permutations<char>(inputSet,
                  GenerateOption.WithoutRepetition);
            string format1 = "Permutations of {{A A C}} without repetition; size = {0}";
            Console.WriteLine(String.Format(format1, P1.Count));
            foreach (IList<char> p in P1)
            {
                Console.WriteLine(String.Format("{{{0} {1} {2}}}", p[0], p[1], p[2]));
            }

        }
    }
}
