using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutTheSticks
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Discards the first line as we don't need to know how many elements which are passed. 
            Console.ReadLine();
            
            string[] tokens = Console.ReadLine().Split(' ');

            List<int> lengths = new List<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                lengths.Add(Convert.ToInt32(tokens[i]));
               
            }
            lengths.Sort();
            lengths.Reverse();
            while (lengths.Count > 0)
            {
                Console.WriteLine(lengths.Count);
                int cutLenght = lengths[lengths.Count-1];
               // List<int> eraseList = new List<int>();
                for (int i = lengths.Count-1; i >=0; i--)
                {
                    lengths[i] -= cutLenght;
                    if(lengths[i]<=0)
                    {
                        lengths.RemoveAt(i);
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
