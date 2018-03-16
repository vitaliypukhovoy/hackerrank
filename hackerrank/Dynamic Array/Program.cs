using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Array
{

    class Solution
    {
        static void Main(String[] args)
        {

            List<List<int>> list = new List<List<int>>();
            List<List<int>> lists = new List<List<int>>();
            list.Capacity = 100000;
            lists.Capacity = 100000;

            string line;
            while ((line = Console.ReadLine()) != null && line != null)
            {
                list.Add(line.Split(' ').Select(Int32.Parse).ToList());
            }


            var N = list[0][0];
            var Q = list[0][1];
            int lastAnswer = 0;
            list.RemoveAt(0);

            for (int i = 0; i < N; i++)
            {
                lists.Add(new List<int>());
            }

            int f, x, y;

            for (int i = 0; i < Q; i++)
            {

                f = list[i][0];
                x = list[i][1];
                y = list[i][2];

                int seq = (x ^ lastAnswer) % N;

                List<int> s = lists[seq];
                if (f == 1)
                {
                    s.Add(y);
                }
                else
                {
                    int num = y % s.Count;
                    lastAnswer = s[num];
                    Console.WriteLine(lastAnswer);
                }
            }
            Console.ReadKey();

        }
    }
}
