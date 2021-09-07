using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputSet = { 'A', 'B', 'C', 'D' };
                        
            Variations<char> variations = new Variations<char>(inputSet, 2);
            string vformat = "Variations of {{A B C D}} choose 2: size = {0}";
            Console.WriteLine(String.Format(vformat, variations.Count));
            foreach (IList<char> v in variations)
            {
                Console.WriteLine(String.Format("{{{0} {1}}}", v[0], v[1]));
            }
        }
    }
}
