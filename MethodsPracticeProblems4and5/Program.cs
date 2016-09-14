using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeProblems4and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 4

            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));

            //Problem 5

            Console.WriteLine("Give me a number to double.");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Double(userNum));
        }

        static int Sum(int[] example)
        {
            int total = 0;
            foreach (int value in example)
            {
                total += value;
            }
            return total;
        }

        static int Double(int userNum)
        {
            int doubleMint = userNum*2;
            return doubleMint;
        }

    }
}
