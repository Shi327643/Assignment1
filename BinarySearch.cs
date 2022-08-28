using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolutions
{
    internal class BinarySearch
    {


        //static void Main(string[] args)
        //{
            
        //    int[] arr = new int[10];
        //    for (int num1 = 0; num1 < arr.Length; num1++)
        //    {
        //        Console.Write("Enter the elements of array:-\t");
        //        arr[num1] = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine("***************************************************************");


        //    Console.WriteLine("Enter the value to be searched:");
        //    int s_val = int.Parse(Console.ReadLine());
          
        //    int number = arr.Length;
        //    int res = binarySearch(arr, 0, number - 1, s_val);


        //    Console.WriteLine("***************************************************************");
        //    Console.WriteLine("The elements of the arrays in sorted format are:");
        //    Array.Sort(arr);
        //    for (int num1 = 0; num1 < number; num1++)
        //    {
        //        Console.WriteLine(arr[num1] + " ");
        //    }
        //    Console.WriteLine();

        //    Console.WriteLine("***************************************************************");
        //    Console.WriteLine("Element to be searched is:" + s_val);
        //    if (res == -1)
        //    {
        //        Console.WriteLine("Element is not present in array");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Element is present at" + " " + res + "th" + " " + "position of array");
        //    }

        //    Console.ReadLine();

        //}
        static int binarySearch(int []arr, int start, int end, int s_val)
        {
            int mid;
            if (end >= start)
            {
                mid = (start + end) / 2;

                if (arr[mid] == s_val)
                {
                    return mid+1;
                }
                else if (arr[mid] < s_val)
                {
                    return binarySearch(arr, mid+1 ,end, s_val);
                }
                else
                {
                    return binarySearch(arr,start, mid-1, s_val);
                }

            }
            return -1;
        }
    }
}
