using System;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
                int testAmount = Convert.ToInt32(Console.ReadLine());
                int min;
                int max;
                while (testAmount-- > 0)
                {
                    
               string[] tokens = Console.ReadLine().Split(' ');
                min = Convert.ToInt32(tokens[0]);
                max = Convert.ToInt32(tokens[1]);
                 
                Console.WriteLine((int)Math.Floor(Math.Sqrt(max)) - Math.Ceiling(Math.Sqrt(min)) + 1);
                }
        }
    }
}
