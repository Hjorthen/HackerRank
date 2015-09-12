using System;
using System.Collections.Generic;
using System.IO;


class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[t,t];
        for (int i = 0; i < t; ++i)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            for (int n = 0; n < t; ++n)
            {
                arr[i,n] = Convert.ToInt32(elements[n]);
            }
        }
        //Calculates the diagonals: 
        int sum1 = 0;
        int sum2 = 0;
        //0, 4, 8
        for (int i = 0, m = 0; i < t; ++i, ++m)
        {
            sum1 += arr[i, m];
            sum2 += arr[(t - i -1),m];
        }
        Console.WriteLine(Math.Abs(sum1 - sum2));
        Console.ReadLine();
    }
}