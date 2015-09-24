using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort2
{
    class QuickSort2
    {
        //Does not support duplicate values
        static int[] QuickSort(int [] arr)
        {
            if(arr.Length <=1)
            {
                return arr;
            }
            int pivot = arr[0];
            List<int> lower = new List<int>();
            List<int> higher = new List<int>();
            foreach (int num in arr)
            {
                if(num > pivot)
                {
                    higher.Add(num);
                }
                else if(num < pivot)
                {
                    lower.Add(num);
                }
            }
            
            //Sorts out sub-arrays
            int[] sortedLower = QuickSort(lower.ToArray());
            int[] sortedHigher = QuickSort(higher.ToArray());

            //Defines a new array which has space for lower, pivot and higher numbers
            int[] retArr = new int[sortedHigher.Length + sortedLower.Length+1];

            //Copies the lower values in first
            Array.Copy(sortedLower, 0, retArr, 0, sortedLower.Length);
            //Adds the pivot
            retArr[sortedLower.Length] = pivot;
            //Copies the higher values in 
            Array.Copy(sortedHigher, 0, retArr, sortedLower.Length + 1, sortedHigher.Length);
            Console.WriteLine(String.Join(" ", retArr));
            //Returns the array
            return retArr;
        }

        static void Main(string[] args)
        {

            int arrSize;
            arrSize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrSize];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = Convert.ToInt32(split_elements[i]);
            }
            int[] result = QuickSort(arr);
            Console.ReadLine();


        }
    }
}
