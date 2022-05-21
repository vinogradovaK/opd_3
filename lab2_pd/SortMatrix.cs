using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class SortMatrix
    {
        public void sortMatrix(Matrix matrix, bool sign,  IBaseAlgorithm algorithm)
        {
            for (int i = 1; i < matrix.Rows; i++)
            {
                int key = algorithm.Handle(matrix[i]);
                int[] tempRow = matrix[i]; 
                int j = i - 1;

                while (j >= 0 && direction(sign, algorithm.Handle(matrix[j]), key))
                {
                    matrix[j + 1] = matrix[j];
                    j -= 1;
                }
                matrix[j + 1] = tempRow;
            }

        }

        private bool direction(bool sign, int a1, int a2)
        {
            if (sign)
            {
                return a1 > a2;
            }
            else
            {
                return a1 < a2;
            }
        }
    }
}
