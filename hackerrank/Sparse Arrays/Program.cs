using System;
using System.Collections.Generic;
using System.Text;

namespace Sparse_Arrays
{
    class Solution
    {
        static void Main(string[] args)
        {
            int result = 0;
            string line;
            List<string> list = new List<string>();
            ArrayList arr = new ArrayList();
            Hashtable hash = new Hashtable();


            while ((line = Console.ReadLine()) != null && line != "" && line.Length < 20)
            {
                list.Add(line);
            }
            list.ForEach(n =>
            {
                if (int.TryParse(n, out result))
                    return;

                if (hash.Values.Cast<int>().Sum() != int.Parse(list[0]))
                {
                    if (hash.ContainsKey(n))
                    {
                        int? param = hash[(object)n] as Nullable<int>;
                        if (param != null)
                        {
                            param++;
                            hash[(object)n] = (object)param;
                        }
                    }
                    else
                    {
                        hash.Add(n, 1);
                    }
                }
                else
                {
                    arr.Add(n);
                }
            }
            );

            for (int i = 0; i < arr.Count; i++)
            {
                if (hash.ContainsKey(arr[i]))
                    Console.WriteLine(hash[arr[i]]);
                else
                    Console.WriteLine(0);

            }

            Console.ReadLine();
        }
    }
}
