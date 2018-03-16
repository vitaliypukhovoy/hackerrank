﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2D_Array___DS
{
    class Solution
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int[][] arr2 = new int[12][];

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            for (int i = 0; i < arr.Length * 2; i++)
            {
                if (i == 0)
                {
                    Add(arr, arr2, i, i);
                }
                else if (i == 1)
                {
                    AddSmall(arr, arr2, i, i);
                    Add(arr, arr2, i, i + 2);
                }
                else if (i == 2)
                {
                    Add(arr, arr2, i, i);
                    Add(arr, arr2, i, i + 4);
                    AddSmall(arr, arr2, i, i + 2);
                }
                else if (i == 3)
                {
                    AddSmall(arr, arr2, i, i + 4);
                    Add(arr, arr2, i, i + 6);
                    Add(arr, arr2, i, i + 2);
                }
                else if (i == 4)
                {
                    Add(arr, arr2, i, i + 4);
                    AddSmall(arr, arr2, i, i + 6);
                }
                else if (i == 5)
                {
                    Add(arr, arr2, i, i + 6);
                }
            };

            List<List<int>> list = new List<List<int>>(12);

            foreach (var i in arr2)
            {
                list.Add(i.ToList());
            }

            int sum = Sum(list, arr2).Max(i => i.Value);

            Console.Write(sum);

            Console.ReadKey();
        }


        public static Dictionary<int, int> Sum(List<List<int>> list, int[][] arr2)
        {
            var sumDic = new Dictionary<int, int>();
            int idx = 1;
            int n = 1;
            int sum = 0;
            int k = 0;

            for (int p = 0; p < 4; p++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        if (arr2[i].Length == 12 && n < 3)
                        {
                            int temp = list[i].ElementAt(0);
                            sum += temp;
                            n++;
                            list[i].RemoveAt(0);
                            continue;
                        }

                        else if (arr2[i].Length == 12 && n == 3)
                        {
                            int temp = list[i].ElementAt(0);
                            sum += temp;

                            n = 1;
                            k++;
                            if (k != 0 && k % 3 == 0)
                            {
                                sumDic.Add(idx, sum);
                                sum = 0;
                                idx++;
                            }
                            list[i].RemoveAt(0);
                            break;
                        }

                        else if (arr2[i].Length == 4)
                        {
                            int temp = list[i].ElementAt(0);
                            sum += temp;
                            list[i].RemoveAt(0);
                            k++;
                            break;
                        }
                    }
                }
            }
            return sumDic;

        }

        public static void AddSmall(int[][] arr, int[][] arr2, int i, int i2)
        {
            var list = new List<int>();

            for (int j = 0; j < arr[i].Length; j++)
            {
                if (j == 1)
                {
                    var temp = arr[i][j];
                    list.Insert(0, temp);
                }
                else if (j == 2)
                {
                    var temp = arr[i][j];
                    list.Insert(1, temp);
                }
                else if (j == 3)
                {
                    var temp = arr[i][j];
                    list.Insert(2, temp);
                }
                else if (j == 4)
                {
                    var temp = arr[i][j];
                    list.Insert(3, temp);
                    arr2[i2] = list.ToArray();
                    break;
                }

            }
        }

        public static void Add(int[][] arr, int[][] arr2, int i, int i2)
        {
            var list = new List<int>();
            for (int j = 0; j < arr[i].Length * 2; j++)
            {
                if (j < 3)
                {
                    var temp = arr[i][j];
                    list.Add(temp);
                }
                else if (j == 3 || 3 < j && j < 6)
                {
                    var temp = arr[i][j - 2];
                    list.Add(temp);
                }
                else if (j == 6 || 6 < j && j < 9)
                {
                    var temp = arr[i][j - 4];
                    list.Add(temp);
                }
                else if (j == 9 || 9 < j && j < 12)
                {
                    var temp = arr[i][j - 6];
                    list.Add(temp);
                    arr2[i2] = list.ToArray();
                }
            }
        }
    }
}
