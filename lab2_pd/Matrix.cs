using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Matrix
    {

        private int rows;
        private int[][] data;

        public Matrix(int[][] initData)
        {
            this.data = initData;
            this.rows = initData.GetLength(0);
        }

        public int[] this[int i]
        {
            get => data[i];
            set => data[i] = value;
        }

        public int Rows
        {
            get => rows;
        }



        public int[][] Data
        {
            get => data;
        }

    }
}
