using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age;
            Console.WriteLine("Please enter is your age? ");
            age = uint.Parse(Console.ReadLine());
            Console.WriteLine("Your maximum heart rate should be {0} beats per minute", 220 - age);
            Console.WriteLine("Your target HR Zone is {0} - {1} beats per minute", Math.Round((220 - age) * 0.5), Math.Round((220 - age) * 0.85));
            Console.Read();
        }
    }
}
