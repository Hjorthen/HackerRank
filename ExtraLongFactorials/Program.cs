using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(N));
            Console.ReadLine();

        }
        static BigInteger Factorial(int N)
        {
            if (N <= 1)
                return 1;
            return N*Factorial(--N);
        }
    }
}
