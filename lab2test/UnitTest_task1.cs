using NUnit.Framework;
using lab2;
using lab22;

namespace tests
{
    public class Tests
    {

        [Test]
        public void TestSortByMaxElement()
        {
            int res = 10;
            int[] arr = new int[] { 0, 10, 0};

            SortByMaxElement sortByMaxElement = new SortByMaxElement();
            Assert.AreEqual(res, sortByMaxElement.Handle(arr)); 
        }

        [Test]
        public void TestSortByMinElement()
        {
            int res = 0;
            int[] arr = new int[] { 1, 10, 0 };

            SortByMinElement sortByMinElement = new SortByMinElement();
            Assert.AreEqual(res, sortByMinElement.Handle(arr));
        }

        [Test]
        public void TestSortBySum()
        {
            int res = 3;
            int[] arr = new int[] { 1, 1, 1 };

            SortBySum sortBySum = new SortBySum();
            Assert.AreEqual(res, sortBySum.Handle(arr));
        }

        [Test]
        public void TestSortMatrixSumUp()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 2, 2, 2 },
            new int[] { 0, 0, 0},
            new int[] { 1, 1, 1}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { 2, 2, 2 }
                };

            sortMatrix.sortMatrix(matrix, true, new SortBySum());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixSumDown()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 2, 2, 2 },
            new int[] { 0, 0, 0},
            new int[] { 1, 1, 1}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 2, 2, 2 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 0, 0}
                };

            sortMatrix.sortMatrix(matrix, false, new SortBySum());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixMaxUp()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 5, 7, 6 },
            new int[] { 1, 2, 3},
            new int[] { 0, 0, 0}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3 },
                new int[] { 5, 7, 6}
                };

            sortMatrix.sortMatrix(matrix, true, new SortByMaxElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixMaxDowm()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3 },
                new int[] { 5, 7, 6}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 5, 7, 6 },
            new int[] { 1, 2, 3},
            new int[] { 0, 0, 0}
                };

            sortMatrix.sortMatrix(matrix, false, new SortByMaxElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }


        [Test]
        public void TestSortMatrixMinUp()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 2, 2, 2 },
                new int[] { 1, 1, 3 },
                new int[] { 5, 0, 2}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                
                new int[] { 5, 0, 2 },
            new int[] { 1, 1, 3},
            new int[] { 2, 2, 2}
                };

            sortMatrix.sortMatrix(matrix, true, new SortByMinElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(matrix[i][j], res[i][j]);
                }
            }
        }

        [Test]
        public void TestSortMatrixMinDowm()
        {
            Matrix matrix = new Matrix(new int[][]
            {
            new int[] { 5, 0, 2 },
            new int[] { 1, 1, 3},
            new int[] { 2, 2, 2}
            });
            SortMatrix sortMatrix = new SortMatrix();

            int[][] res = new int[][]
                {
                new int[] { 2, 2, 2 },
                new int[] { 1, 1, 3 },
                new int[] { 5, 0, 2}
                };

            sortMatrix.sortMatrix(matrix, false, new SortByMinElement());

            for (int i = 0; i < res.Length; i++)
            {
                int[] temp = res[i];
                for (int j = 0; j < res[i].Length; j++)
                {
                    Assert.AreEqual(res[i][j], matrix[i][j]);
                }
            }
        }
    }
}