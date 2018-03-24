using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Queue_using_Two_Stacks
{
    class Solution
    {

        static void Main(String[] args)
        {
            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();
            List<List<int>> list = new List<List<int>>();

            string line;
            while ((line = Console.ReadLine()) != null && line != null)
            {
                list.Add(line.Split(' ').Select(Int32.Parse).ToList());
            }

            list.Reverse();

            foreach (var item in list)
            {
                st1.Push(item[0]);
                if (item.FindIndex(i => i == 1) != -1)
                    st2.Push(item[1]);
                else
                    st2.Push(0);
            }

            st1.Pop();
            st2.Pop();

            //  int tmp = 0; ;
            for (int i = 0; i < st1.Count; i++)
            {

                if (st1.ElementAt(i) == 1)
                {
                    //  tmp = st2.Peek(); 
                    //     st1.Pop();
                }
                else if (st1.ElementAt(i) == 2)
                {
                    st2.Pop();
                    st2.Pop();
                    st1.Pop();
                    // st1.Pop();

                }
                else if (st1.ElementAt(i) == 3)
                {
                    Console.WriteLine(st2.Peek());
                    st1.Pop();
                    // Console.WriteLine(st1.ElementAt(i) + " " + st2.ElementAt(i));
                    // st1.Pop();
                }
                // Console.WriteLine(st1.ElementAt(i));
            }

            //  foreach(var el in st2)
            //       Console.WriteLine(el);

        }
    }
}
