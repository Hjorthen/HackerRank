using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculate_e_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterationAmount = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<iterationAmount;++i)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double result = CalculateEPow(x);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
        static double CalculateEPow(double x)
        {
            double sum = 0;
            for (uint i = 0; i < 10; ++i)
            {
                sum+= Math.Pow(x, i) / CalculateFraction(i);
            }
            return sum;
        }
        static uint CalculateFraction(uint x)
        {
            if (x <= 1)
                return 1;
            return (x * CalculateFraction(--x));
        }
    }
}
