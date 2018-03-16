using System;
using System.Collections.Generic;
using System.Text;

namespace Equal_Stacks
{
    class Solution
    {
        static void Main(String[] args)
        {
            Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();


            int[] h1 = Console.ReadLine().Split(' ').Select(Int32.Parse).Reverse().ToArray();

            int[] h2 = Console.ReadLine().Split(' ').Select(Int32.Parse).Reverse().ToArray();

            int[] h3 = Console.ReadLine().Split(' ').Select(Int32.Parse).Reverse().ToArray();

            Stack<int> st1 = new Stack<int>(h1);
            Stack<int> st2 = new Stack<int>(h2);
            Stack<int> st3 = new Stack<int>(h3);

            int sum1 = st1.Sum();
            int sum2 = st2.Sum();
            int sum3 = st3.Sum();

            bool flag = true;
            int height = 0;
            while (flag)
            {
                if (sum3 == sum1 && sum3 == sum2)
                {
                    height = sum1;
                    break;
                }
                int max = Math.Max(sum1, Math.Max(sum2, sum3));

                if (sum1 == max)
                {
                    sum1 = sum1 - st1.Pop();

                }

                else if (sum2 == max)
                {
                    sum2 = sum2 - st2.Pop();
                }

                else if (sum3 == max)
                {
                    sum3 = sum3 - st3.Pop();
                }

            }

            Console.WriteLine(height);
        }
    }
}
