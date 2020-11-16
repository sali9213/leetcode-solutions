using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Medium;
using LeetCode.Easy;
using LeetCode.Hard;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            UniquePaths uniquePaths = new UniquePaths();
            var res = uniquePaths.UniquePathsCalc(3, 7);
            Console.WriteLine(res);

        }
    }


}
