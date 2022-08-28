using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolutions
{
    internal class BubbleSort
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[10];

        //    for(int num1 = 0; num1 < arr.Length; num1++)
        //    {
        //        Console.Write("Enter the elements of array:-\t");
        //        arr[num1] = int.Parse(Console.ReadLine());
        //    }

        //    Console.WriteLine("************************************************************");
        //    Console.WriteLine("Array befor sort:");
        //    for(int num1=0;num1 < arr.Length; num1++)
        //    {
        //        Console.WriteLine(arr[num1]+" ");
        //    }
           
        //    Console.WriteLine("************************************************************");

        //    bubbleSort(arr);
        //    Console.WriteLine("Array after sort:");
        //    for(int num1=0;num1 <= arr.Length; num1++)
        //    {
        //        Console.WriteLine(arr[num1] + " ");
        //    }
        //    Console.ReadLine();
        //} 

        static void bubbleSort(int[] arr)
        {
            int number = arr.Length;
            int temp = 0;
            for(int num1=0;num1< number; num1++)
            {
                for(int num2=1;num2<(number-1); num2++)
                {
                    if (arr[num2 - 1] > arr[num2])
                    {
                        temp = arr[num2 - 1];
                        arr[num2-1] = arr[num2];
                        arr[num2] = temp;
                    }
                }
            }

        }
    }
}
