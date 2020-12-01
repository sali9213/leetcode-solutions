using System;
namespace LeetCode.Medium
{
    public static class IntergerToRoman
    {
        public static string IntToRoman(int num)
        {
            string result = "";
            if(num >= 900)
            {
                if(num >= 1000)
                {
                    return "M" + IntToRoman(num - 1000);
                } else
                {
                    return "CM" + IntToRoman(num - 900);
                }

            } else if(num >= 400)
            {
                if(num >= 500)
                {
                    return "D" + IntToRoman(num - 500);
                }
                else
                {
                    return "CD" + IntToRoman(num - 400);
                }

            } else if(num >= 90)
            {
                if(num >= 100)
                {
                    return "C" + IntToRoman(num - 100);
                } else
                {
                    return "XC" + IntToRoman(num - 90);
                }

            } else if(num >= 40)
            {
                if(num >= 50)
                {
                    return "L" + IntToRoman(num - 50);
                } else
                {
                    return "XL" + IntToRoman(num - 40);
                }

            } else if(num >= 9)
            {
                if(num >= 10)
                {
                    return "X" + IntToRoman(num - 10);
                } else
                {
                    return "IX" + IntToRoman(num - 9);
                }

            } else if (num >= 4)
            {

                if(num >= 5)
                {
                    return "V" + IntToRoman(num - 5);
                } else
                {
                    return "IV" + IntToRoman(num - 4);
                }

            } else
            {
                for (int i = 0; i < num; i++)
                {
                    result += "I";
                }
                return result;
            }
        }
           
    }
}
