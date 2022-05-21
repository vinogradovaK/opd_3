using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(new int[][]
{
new int[] { 2, 1, 4, 3, 7 },
new int[] { 1, 2, 5, 5, 3 },
new int[] { 0, 22, 1, 12, 0 }
});
            SortMatrix sorter = new SortMatrix();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Выберите тип сортировки:");
                Console.WriteLine("1 – По сумме элементов строк матрицы");
                Console.WriteLine("2 – По максимальному элементу в строке матрицы");
                Console.WriteLine("3 – По минимальному элементу в строке матрицы");
                Console.WriteLine("0 - Выход из программы");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1': sorter.sortMatrix(matrix, chooseSign(), new SortBySum()); ; break;
                    case '2': sorter.sortMatrix(matrix, chooseSign(), new SortByMaxElement()); ; break;
                    case '3': sorter.sortMatrix(matrix, chooseSign(), new SortByMinElement()); ; break;
                    case '0': return;
                    default: break;
                }
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j].ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static bool chooseSign()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1 – По возрастанию");
                Console.WriteLine("2 – По убыванию");
                Console.WriteLine("");

                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1': return true;
                    case '2': return false;
                    default: break;
                }
            }
        }
    }
}