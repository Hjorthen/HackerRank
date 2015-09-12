using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());
            char[] output = new char[height];
            for(int i=0;i<output.Length;++i)
            {
                output[i] = ' ';
            }
            for(int i= height-1;i>=0;--i)
            {
                output[i] = '#';
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
