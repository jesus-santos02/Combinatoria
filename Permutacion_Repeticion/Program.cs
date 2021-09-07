using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutacion_Repeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputSet = { 'A', 'A', 'C' };

            Permutations<char> P2 = new Permutations<char>(inputSet,
                  GenerateOption.WithRepetition);
            string format2 = "Permutations of {{A A C}} with Repetition; size = {0}";
            Console.WriteLine(String.Format(format2, P2.Count));
            foreach (IList<char> p in P2)
            {
                Console.WriteLine(String.Format("{{{0} {1} {2}}}", p[0], p[1], p[2]));
            }
        }
    }
}
