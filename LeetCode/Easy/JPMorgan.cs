using System;
namespace LeetCode.Easy
{
    public static class JPMorgan
    {
        public static void Taks1(string line)
        {
            bool isFirstLetter = true;

            for (int i = 0; i < line.Length; i++)
            {
                if (isFirstLetter)
                {
                    Console.Write(char.ToUpper(line[i]));
                    isFirstLetter = false;
                }
                else
                {
                    Console.Write(line[i]);
                    if (line[i] == ' ')
                    {
                        isFirstLetter = true;
                    }
                }
            }

        }

        public static int Task2(string s)
        {

            if(s == null || s.Length == 0 || s[0] == '0')
                return 0;

            int n = s.Length;
            int[] mem = new int[n + 1];

            mem[0] = 1;
            mem[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                int n1 = int.Parse(s.Substring(i - 1, 1));
                int n2 = int.Parse(s.Substring(i - 2, 2));

                int c1 = 0;
                if(n1 > 0)
                {
                    c1 = mem[i - 1];
                }

                int c2 = 0;
                if(n2 >= 10 && n2 <= 26)
                {
                    c2 = mem[i - 2];
                }

                mem[i] = c1 + c2;
            }

            return mem[n];



        }

    }
   
}
