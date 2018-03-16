using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays__DS
{
    class Solution
    {
        static void Main(String[] args)
        {
            Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');

            var arrRev = arr_temp.Reverse().ToArray();
            int[] arr = Array.ConvertAll(arrRev, s => int.Parse(s));

            //   List<int> arr1 = arr.ToList();

            //  arr1.ForEach(i => Console.Write("{0}\t", i));
            foreach (var item in arr)
                Console.Write(item + " ");
        }
    }
}
