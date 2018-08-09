using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_MinMaxSum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            Array.Sort(arr);
            long[] result = { arr[0] + arr[1] + arr[2] + arr[3], arr[1] + arr[2] + arr[3] + arr[4] }; //min, max
            Console.WriteLine(String.Join(" ", result));
        }


        
    }
}
