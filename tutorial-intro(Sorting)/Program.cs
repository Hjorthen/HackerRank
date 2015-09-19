using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_intro_Sorting_
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine(); //Gets the value to be found
            Console.ReadLine(); //Skips the variable containing array size
            string[] s = Console.ReadLine().Split(' ');
            int result = -1;   
            //Search for the value
            for (int i = 0; i < s.Length; i++)
            {
               if(val.CompareTo(s[i])==0)
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
