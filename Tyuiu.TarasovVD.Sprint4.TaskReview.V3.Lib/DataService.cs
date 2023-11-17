using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TarasovVD.Sprint4.TaskReview.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int сount = 0;

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    char character = value[index++];
                    if (char.IsDigit(character))
                    {
                        int digit = int.Parse(character.ToString());
                        matrix[i, j] = digit;
                        if (digit % 2 != 0)
                        {
                            сount++;
                        }
                    }
                }
            }

            return сount;
        }
    }
}
