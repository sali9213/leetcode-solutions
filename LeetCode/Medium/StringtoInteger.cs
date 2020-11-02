using System;
namespace LeetCode.Medium
{
    public static class StringtoInteger
    {
        public static int atoi(string str)
        {
            if (str.Length == 0) return 0;

            int result = 0;
            int i = 0;
            int sign = 1;

            while (i < str.Length && str[i] == ' ') i++;

            if (i < str.Length && (str[i] == '-' || str[i] == '+'))
            {
                sign = str[i++] == '-' ? -1:1;
            }

            for (; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    if(result > int.MaxValue / 10 || (result == int.MaxValue/10 && str[i] - '0' > int.MaxValue % 10))
                    {
                        return sign == 1 ? int.MaxValue : int.MinValue;
                    }
                    result = (int)((result * 10) + str[i] - '0');
                } else
                {
                    break;
                }
            }

            return result * sign;
        }
    }
}
