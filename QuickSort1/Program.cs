using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{
    class Program
    {

        int[] QuickSort(int[] arr)
        {
     
            return null;
        }

        static void Main(String[] args)
        {

            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                arr[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            List<int> lowerVal = new List<int>();
            List<int> higherVal = new List<int>();
            int pivot = arr[0];
            foreach (int val in arr)
            {
                if(val < pivot)
                {
                    lowerVal.Add(val);
                }
                else if(val > pivot)
                {
                    higherVal.Add(val);
                }
            }
            StringBuilder retStr = new StringBuilder(_ar_size * 2);
            retStr.Append(String.Join(" ", lowerVal.ToArray()));
            retStr.Append(" "+ pivot + " ");
            retStr.Append(String.Join(" ", higherVal.ToArray()));
            Console.WriteLine(retStr);
            Console.ReadLine();

            //QuickSort(_ar);
        }
    }
}

