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
            string input = "FLF";
            int res = Task3(input);
            Console.WriteLine(res);
        }

        static int Task1(string input)
        {
            Dictionary<char, bool> dict = new Dictionary<char, bool>();
            int count = 0;

            foreach(char c in input)
            {
                if(dict.ContainsKey(c) && !dict[c])
                {
                    count++;
                    dict[c] = true;
                } else if(!dict.ContainsKey(c))
                {
                    dict.Add(c, false);
                }
            }

            return count;
        }

        static int Task2(string input)
        {
            int secondHighestDigit = int.MinValue;
            int highestDigit = int.MinValue;

            foreach(char c in input)
            {
                if(char.IsNumber(c))
                {
                    if(c - '0' >= highestDigit)
                    {
                        secondHighestDigit = highestDigit;
                        highestDigit = c - '0';
                    } else if(c - '0' > secondHighestDigit)
                    {
                        secondHighestDigit = c - '0';
                    }
                }
            }

            if (secondHighestDigit == int.MinValue)
                secondHighestDigit = -1;

            return secondHighestDigit;
        }

        static int Task3(string directions)
        {
            int x_coord = 0;
            int y_coord = 0;

            int turns = 0;

            int direction_index = 0;
            int mov_dir_length = 4;

            int[,] mov_dir = new int[,]
            {
                { 0,1 },
                { 1,0 },
                { 0,-1 },
                { -1,0 }
            };

            // Calculate coordinates based on given commands
            foreach(char c in directions)
            {

                if(c == 'F')
                {
                    x_coord += mov_dir[direction_index,0];
                    y_coord += mov_dir[direction_index, 1];
                } else if(c == 'L')
                {
                    direction_index = (direction_index - 1 + mov_dir_length) % mov_dir_length;
                } else if(c == 'R')
                {
                    direction_index = (direction_index + 1 + mov_dir_length) % mov_dir_length;
                }
            }



            // Calculate number of commands to return to starting position
            if(x_coord != 0)
            {
                int move_direction = 0;
                if (x_coord > 0)
                    move_direction = -1;
                else
                    move_direction = 1;

                int x_turn_count = 0;

                while (mov_dir[direction_index,0] != move_direction)
                {

                    direction_index = (direction_index + 1 + mov_dir_length) % mov_dir_length;
                    x_turn_count++;
                }

                if (x_turn_count == 3)
                    x_turn_count = 1;

                if (x_turn_count == 2 && y_coord != 0)
                    turns--;

                turns += x_turn_count;
                turns += Math.Abs(x_coord);
                x_coord = 0;


            }

            if (y_coord != 0)
            {
                int move_direction = 0;
                if (y_coord > 0)
                    move_direction = -1;
                else
                    move_direction = 1;

                int y_turn_count = 0;

                while (mov_dir[direction_index,1] != move_direction)
                {
                    direction_index = (direction_index + 1 + mov_dir_length) % mov_dir_length;
                    y_turn_count++;
                }

                if (y_turn_count == 3)
                    y_turn_count = 1;

                turns += y_turn_count;
                turns += Math.Abs(y_coord);
                y_coord = 0;
            }

            return turns;
        }
    }
}
