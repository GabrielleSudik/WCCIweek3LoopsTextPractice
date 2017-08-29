using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek3LoopsTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a while loop with break to do factorials

            Console.WriteLine("Please enter a smallish number.");
            int n = int.Parse(Console.ReadLine());

            decimal factorial = 1; //decimal keyword is for large integers

            while (true)
            {
                if (n <= 1)
                {
                    break;
                }

                factorial *= n;
                n--;
            }

            Console.WriteLine($"The factorial of your number is {factorial}.");

            //now write the factorial calculation with a do...while loop

            Console.WriteLine("\nPlease enter a new smallish number.");
            int n2 = int.Parse(Console.ReadLine());

            decimal factorial2 = 1;

            do
            {
                factorial2 *= n2;
                n2--;
            }

            while (n2 > 0);

            Console.WriteLine($"The factorial of your number is {factorial2}.");

            //a do...while loop calulating the product of a sequence of numbers:

            Console.WriteLine("\nInput one more smallish number.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("And input one more.");
            int y = int.Parse(Console.ReadLine());

            int num3 = x;
            long product = 1;

            do
            {
                product *= num3;
                num3++;
            }

            while (num3 <= y);

            Console.WriteLine($"The product of all numbers between yours is: {product}.");

            //for loops
            //initialize a counter, set a condition, tally the counter

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            //you can do more than one thing in the for loop. example:

            for (int i = 1, sum = 1; i < 128; i = i * 2, sum += i)
            {
                Console.WriteLine($"i = {i} and sum = {sum}.");
            }

            //raise R to the S with a for loop:

            Console.WriteLine("\nEnter a smallish base number.");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter a power to raise it to.");
            int s = int.Parse(Console.ReadLine());

            decimal result = 1;

            for (int i = 0; i < s; i++)
            {
                result *= r;
            }

            Console.WriteLine($"\n{r} to the power of {s} is {result}.");


            Console.ReadLine();
        }
    }
}
