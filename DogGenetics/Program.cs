using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;
            Console.Write("What is your dogs name? ");
            dogName = Console.ReadLine();
            int a = 0; int b = 0; int c = 0; int d = 0; int e = 0;

            int total = 100;
            Random perc = new Random();

            a = perc.Next(50, total);
            total -= a;

            b = perc.Next(0, total);
            total -= b;

            c = perc.Next(0, total);
            total -= c;

            d = perc.Next(0, total);
            total -= d;

            e = total;

            Console.WriteLine("Well then, I have this highly reliable report on \n" + dogName + ", prestigious background right here.");
            Console.WriteLine("\n" + dogName + " is: \n ");
            Console.WriteLine("{0}% St. Bernard \n{1}% Chihuahua \n{2}% Common Cur \n{3}% Asian Pug \n{4}% King Doberman\n" , a, b, c, d, e,  a + b + c + d + e );
            Console.WriteLine("\nWow, that's QUITE the dog!");
        }
    }
}
