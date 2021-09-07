using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] inputSet = { 'A', 'B', 'C', 'D' };

            //Combinations<char> combinations = new Combinations<char>(inputSet, 3);
            //string cformat = "Combinations of {{A B C D}} choose 3: size = {0}";
            //Console.WriteLine(String.Format(cformat, combinations.Count));
            //foreach (IList<char> c in combinations)
            //{
            //    Console.WriteLine(String.Format("{{{0} {1} {2}}}", c[0], c[1], c[2]));
            //}

            //int[] inputSet = { 1, 2, 3, 4, 5, 6, 7 };

            //Combinations<int> combinations = new Combinations<int>(inputSet, 3);
            //string cformat = "Combinations of {{A B C D}} choose 3: size = {0}";
            //Console.WriteLine(String.Format(cformat, combinations.Count));
            //foreach (IList<int> c in combinations)
            //{
            //    Console.WriteLine(String.Format("{{{0} {1} {2}}}", c[0], c[1], c[2]));
            //}

            int N = 38;
            int[] inputSet = new int[N];
            for (int i = 0; i < inputSet.Length; i++)
                    inputSet[i] = i + 1;

            Combinations<int> combinations = new Combinations<int>(inputSet, 6);
            
            using (StreamWriter sw = new StreamWriter("Combinaciones_Loto.txt"))
            {
                foreach (IList<int> c in combinations)
                {
                    sw.WriteLine(String.Format("{{{0} {1} {2} {3} {4} {5}}}", c[0], c[1], c[2], c[3], c[4], c[5]));
                }
            }
        }
    }
}
