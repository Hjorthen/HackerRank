using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine(); //Skip array size
            string[] elements = Console.ReadLine().Split(' ');
            int[] arr = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                arr[i] = Convert.ToInt32(elements[i]);
            }
            //Sort(ONLY WORKS IF THE ELEMENT IS GUARRENTEED TO BE INSERTED AND THERE IS SPACE FOR THE NEW ELEMENT):
            int value = arr[elements.Length - 1];
            for (int i = (arr.Length-1); i >=0; i--)
            {
                
                if (i==0 || value > arr[i-1]) //If our value is higher than the element on its left, this is where it belongs, as the array is sorted already
                {
                    arr[i] = value;
                    break;
                }
                else
                {
                    arr[i] = arr[i - 1];
                }

                StringBuilder Str = new StringBuilder();
                foreach (var item in arr)
                {
                    Str.Append(item + " ");
                }
                Console.WriteLine(Str);
            }
            StringBuilder arrStr = new StringBuilder();
            foreach (var item in arr)
            {
                arrStr.Append(item + " ");
            }
            Console.WriteLine(arrStr);
            Console.ReadLine();
        }
    }
}
