using System;
using System.Collections.Generic;
using System.Text;

namespace Balanced_Brackets
{
    class Solution
    {

        static string isBalanced(string str)
        {
            char[] arr = str.Select(s => s).ToArray();
            //  char [] arr = str.ToCharArray();
            if (str.Length % 2 == 1)
                return "NO";

            Stack<char> st = new Stack<char>();
            //foreach (var ch in list)               
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '{')
                {
                    st.Push('}');
                }
                else if (arr[i] == '[')
                {
                    st.Push(']');
                }
                else if (arr[i] == '(')
                {
                    st.Push(')');
                }
                else if (st.Count > 0 && arr[i] == st.Peek())
                {
                    st.Pop();
                }
                else
                {
                    return "NO";
                }
            }
            return (st.Count > 0) ? "NO" : "YES";
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                string result = isBalanced(s);
                Console.WriteLine(result);
            }
        }
    }

}
