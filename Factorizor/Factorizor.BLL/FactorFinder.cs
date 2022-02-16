using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class FactorFinder
    {
        public int[] FindFactors(int num, out int numfactors)
        {
            int[] facts = new int[80]; // size of 80 is arbitrary
            int i, j;
            // Find factors and put them in the facts array.
            for (i = 2, j = 0; i < num / 2 + 1; i++)
            {
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
            }
            numfactors = j;
            return facts;

        }
    }
}
