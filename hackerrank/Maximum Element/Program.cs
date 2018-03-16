using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Element
{
    class Solution
    {
        static void Main(String[] args)
        {
            Stack<StackNode> st1 = new Stack<StackNode>();

            int max = int.MinValue;

            string line;
            while ((line = Console.ReadLine()) != null && line != null)
            {
                int[] ln = line.Split(' ').Select(Int32.Parse).ToArray();
                int choice = ln[0];
                int val = (choice == 1) ? ln[1] : 0;
                max = Math.Max(val, max);


                if (choice == 1)
                {
                    st1.Push(new StackNode(val, max));
                }
                else if (choice == 2)
                {

                    if (st1.Count != 0)
                    {
                        st1.Pop();
                        if (st1.Count != 0)
                            max = st1.Peek().MaxCur();
                        else
                            max = int.MinValue;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine(st1.Peek().MaxCur());
                }

            }

        }

    }

    class StackNode
    {
        public int val;
        public int _max;

        public StackNode(int val, int _max)
        {
            this.val = val;
            this._max = _max;
        }

        public int MaxCur()
        {
            return Math.Max(val, _max);

        }

    }
    


}
