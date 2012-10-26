using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1A3
{
    class t1a3
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, }, { 5, 6, 7 }, { 9, 10, 11 } };
            int[,] b = { { 1, 2, 3, }, { 5, 6, 7 }, { 9, 10, 11 } };
            Matrix matrix1 = new Matrix(a);
            Matrix matrix2 = new Matrix(3,3);
            matrix2.setValue(2, 2, 2);
            Console.WriteLine("Matrix 1");
            matrix1.printMatrix();
            Console.WriteLine("Matrix 2");
            matrix2.printMatrix();
            Console.WriteLine("Matrix nach Addition");
            matrix1.add(matrix2).printMatrix();
            Console.WriteLine("Matrix nach Multi");
            matrix1.multi(matrix2).printMatrix();
            Console.WriteLine("");
        }
    }

    class Matrix
    {
        private int[,] values;
        public Matrix(int[,] values)
        {
            this.values = values;
        }
        public Matrix(int i, int j)
        {
            this.values = new int[i, j];
            for (int ii = 0; ii < i; ii++)
            {
                for (int ij = 0; ij < j; ij++)
                {
                    this.values[ii, ij] = 1;
                }
            }
        }

        public void printMatrix()
        {
            for (int i = 0; i < this.values.GetLength(0);i++ )
            {
                for (int j = 0; j < this.values.GetLength(0); j++)
                {
                    Console.Write(this.getValue(i,j).ToString() + "\t");
                }
                Console.WriteLine("");
            }

        }
        public int getValue(int i, int j)
        {
            return this.values[i, j];
        }

        public Matrix add(Matrix m2)
        {
            int[,] mNew = new int[this.values.GetLength(0), this.values.GetLength(1)];
            for (int i = 0; i < this.values.GetLength(0); i++)
            {
                for (int j = 0; j < this.values.GetLength(1); j++)
                {
                    mNew[i,j ] = this.values[i, j] + m2.getValue(i, j);
                }
            }
            return new Matrix(mNew);
        }

        public Matrix multi(Matrix m2)
        {
            int[,] mNew = new int[this.values.GetLength(0), this.values.GetLength(1)];
            for (int i = 0; i < this.values.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    mNew[i, j] = 0;
                    for (int r = 0; r < this.values.GetLength(1);r++ )
                    {
                        mNew[i, j] += this.getValue(i, r) * m2.getValue(r, j);
                    }
                }
            }
            return new Matrix(mNew);
        }
        public int GetLength(int i)
        {
            return this.values.GetLength(i);
        }
        public void setValue(int i, int j, int value)
        {
            this.values[i, j] = value;
        }
    }
}
