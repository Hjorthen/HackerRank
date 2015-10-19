using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPlaceQuicksort
{
    class Program
    {
        /// <summary>
        /// Performs an in-place sort on the array
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="startIndex">The index at which the sort should start(inclusive)</param>
        /// <param name="endIndex">The index at which the sort should end(exclusive)</param>
        static void InPlaceSort(int[] arr, int startIndex, int endIndex)
        {
            if(endIndex-startIndex<=1)
            {
                return;
            }

            int pivot = arr[endIndex-1];
            int splice = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                int value = arr[i];
                //Those two needs to be swapped. We need equal to make the pivot swap as well. 
                if (value <= pivot)
                {
                    //No need to swap with itself
                    if (splice != i)
                    {
                        //Swap
                        arr[i] = arr[splice];
                        arr[splice] = value;
                    }
                    ++splice;
                }
            }
            //We shall not include the splice(hence the -1)
            Console.WriteLine(String.Join(" ", arr));
            InPlaceSort(arr, startIndex, splice-1);
            InPlaceSort(arr, splice, endIndex);
            
        }
        static void QuickSort(int[] arr)
        {
            InPlaceSort(arr, 0, arr.Length);
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
            /*
            int[] arr = {9, 8, 6, 7, 3, 5, 4, 1, 2};
            */
            QuickSort(arr);
            Console.ReadLine();
        }
    }
}
