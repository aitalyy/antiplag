using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.metods
{
    internal class Diff
    {
        public int Difff(string oldVersion, string newVersion)
        {
            int count = 0;
            int[,] matrix = new int[oldVersion.Length + 1, newVersion.Length + 1];

            for (int i = 0; i <= oldVersion.Length; i++)
            {
                matrix[i, 0] = i;
            }

            for (int j = 0; j <= newVersion.Length; j++)
            {
                matrix[0, j] = j;
            }

            for (int i = 1; i <= oldVersion.Length; i++)
            {
                for (int j = 1; j <= newVersion.Length; j++)
                {
                    if (oldVersion[i - 1] == newVersion[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j], matrix[i, j - 1]), matrix[i - 1, j - 1]) + 1;
                    }
                }
            }

            int x = oldVersion.Length;
            int y = newVersion.Length;

            while (x > 0 || y > 0)
            {
                if (x > 0 && y > 0 && oldVersion[x - 1] == newVersion[y - 1])
                {
                    x--;
                    y--;
                    count++;
                }
                else if (y > 0 && matrix[x, y] == matrix[x, y - 1] + 1)
                {
                    Console.WriteLine("+ " + newVersion[y - 1]);
                    y--;
                    count++;
                }
                else if (x > 0 && matrix[x, y] == matrix[x - 1, y] + 1)
                {
                    Console.WriteLine("- " + oldVersion[x - 1]);
                    x--;
                    count++;
                }
                else if (x > 0 && y > 0 && matrix[x, y] == matrix[x - 1, y - 1] + 1)
                {
                    Console.WriteLine("* " + oldVersion[x - 1] + " -> " + newVersion[y - 1]);
                    x--;
                    y--;
                    count++;
                }
            }
            return count;
        }
    }
}
