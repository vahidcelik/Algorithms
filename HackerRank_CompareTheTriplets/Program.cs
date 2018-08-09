using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerRank_CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
            int[] a = { 0, int.MaxValue };
        }

        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] points = { 0, 0 };

            compare(a0, b0, points);
            compare(a1, b1, points);
            compare(a2, b2, points);

            return points;
        }

        static void compare(int ai, int bi, int[] points)
        {
            if (ai > bi)
                points[0]++;
            else if (bi > ai)
                points[1]++;
        }
    }
}
