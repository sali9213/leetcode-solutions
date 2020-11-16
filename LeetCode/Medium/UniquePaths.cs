using System;
namespace LeetCode.Medium
{
    public class UniquePaths
    {
        public UniquePaths()
        {

        }

        private int[,] mem { get; set; }

        public int UniquePathsCalc(int m, int n)
        {

            if (mem == null)
                mem = new int[m + 1,n + 1];

            if (m == 1 || n == 1)
                return 1;

            if (mem.GetLength(0) > m && mem.GetLength(1) > n && this.mem[m, n] != 0)
                return this.mem[m, n];

            if (mem.GetLength(0) > n && mem.GetLength(1) > m && this.mem[n, m] != 0)
                return this.mem[n, m];

            int val = UniquePathsCalc(m - 1, n) + UniquePathsCalc(m, n - 1);

            mem[m, n] = val;

            if(mem.GetLength(0) > n && mem.GetLength(1) > m)
                mem[n, m] = val;

            return val;

        }

    }
}
