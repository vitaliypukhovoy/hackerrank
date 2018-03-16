using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Manipulation
{
    class Solution
    {

        static void Main(String[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();
            string[] inString = Console.ReadLine().Split(' ');
            uint[] initParams = Array.ConvertAll(inString, UInt32.Parse);
            uint n = initParams[0];
            uint m = initParams[1];

            List<long> list = new List<long>(new long[n + 1]);
            //long [] list = new long [n+1];


            for (int i = 0; i < m; i++)
            {
                long[] array = Console.ReadLine().Split(' ').Select(p => long.Parse(p)).ToArray();
                int a = (int)array[0]; //Int32.Parse(opString[0]);
                int b = (int)array[1]; //nt32.Parse(opString[1]);
                long k = array[2];   // long.Parse(opString[2]);

                list[a] += k;
                if (b + 1 <= n) list[b + 1] -= k;

                // do
                //          {                        
                //              list[a] += k;                     
                //              a++;
                //          }
                //          while (a <= b);
            }


            long max = 0; long temp = 0;
            for (int i = 1; i <= n; i++)
            {
                temp += list[i];
                if (temp > max)
                    max = temp;


            }
            Console.WriteLine(max); //list.Max());

            sw.Stop();
            // Console.WriteLine((sw.ElapsedMilliseconds/100.0).ToString());

        }
    }
}
