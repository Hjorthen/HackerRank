using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertSort2
{
    class Program
    {
        static void PrintArr(int [] arr)
        {
            StringBuilder arrStr = new StringBuilder();
            foreach (var item in arr)
            {
                arrStr.Append(item + " ");
            }
            Console.WriteLine(arrStr);
        }
        static int[] InsertSort(int[] arr)
        {
            //First element was guarranteed to be 1, so skip
            for (int i = 1; i < arr.Length; ++i)
            {
                for (int m = i; m >=0;  m--)
                {
                    //PrintArr(arr);
                    if (m==0 || arr[m-1] <= arr[m])
                    {
                        break;
                    }
                    int tmp = arr[m - 1];
                    arr[m - 1] = arr[m];
                    arr[m] = tmp;
                }
                //PrintArr(arr);
                Console.WriteLine(String.Join(" ", arr));

            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.ReadLine(); //Skip array size
            string[] elements = Console.ReadLine().Split(' ');
            int[] arr = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                arr[i] = Convert.ToInt32(elements[i]);
            }
            //Sort
                arr = InsertSort(arr);

           
           
            Console.ReadLine();
        }
    }
}
