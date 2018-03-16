using System;
using System.Collections.Generic;
using System.Text;

namespace Left_Rotation
{

    class Solution
    {

        static int[] leftRotation(int[] arr, int n, int d)
        {
            Queue<int> tmp = new Queue<int>();
            for (int i = 0; i < d; i++)
                for (int j = n - 1; j >= 0; j = j - 2)
                {

                    if (j != 0)
                    {
                        tmp.Enqueue(arr[j - 1]);
                        arr[j - 1] = arr[j];
                    }
                    if (j == n - 1) { continue; }
                    if (j == 0) { arr[n - 1] = arr[j]; }
                    arr[j] = tmp.Dequeue();
                    if (j == 1)
                    {
                        arr[n - 1] = tmp.Dequeue();
                        break;
                    }
                }
            return arr;
        }

        static void Main(String[] args)
        {
            //  var sw = Stopwatch.StartNew();
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(a_temp, Int32.Parse);
            // int[] result = leftRotation(arr,n,d);
            // Console.WriteLine(String.Join(" ", result));

            int temp = 0;
            Queue<int> array = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                array.Enqueue(arr[i]);
            }

            for (int j = 0; j < d; j++)
            {
                temp = array.Dequeue();
                array.Enqueue(temp);


            }

            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }

            // sw.Stop();
            //    foreach(int num in arr)
            //Console.Write(num + " ");

            //  Console.WriteLine(String.Join(" ", arr));
            // Console.WriteLine(sw.ElapsedTicks);

        }
    }
}
