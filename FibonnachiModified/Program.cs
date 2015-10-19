using System;
using System.Numerics;

namespace FibonnachiModified
{

    class Program
    {
        static BigInteger NextFibonnachi(BigInteger first, BigInteger second)
        { 
            return (BigInteger.Pow(second, 2) + first);
        }
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            watch.Start();
           // String[] tokens = Console.ReadLine().Split(' ');

            BigInteger first = 0;//Convert.ToInt32(tokens[0]);
            BigInteger second = 2;// Convert.ToInt32(tokens[1]);
            int count = 20 - 2;// Convert.ToInt32(tokens[2]) - 2;
            for (int i = 0; i < count; ++i)
            {
                BigInteger next = NextFibonnachi(first, second);
                first = second;
                second = next;
            }
          //  Console.WriteLine(second);
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
