using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    class PerfectChecker
    {
        public static Boolean perfectNumber(int number)
        {
            int perfectNum = 0;

            for (int i = 1; i < number; i++)
            {

                if (number % i == 0)
                    perfectNum += i;
            }
            if (perfectNum == number)
            {
                return true;
                //Console.Write("\n{0} is a perfect number.\n", number);
            }
            else
            {
                return false;
                //Console.Write("\n{0} is not a perfect number.\n", number);
            }

        }
    }
}
