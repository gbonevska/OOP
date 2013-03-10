using System;
using System.Linq;
using System.Collections.Generic;


namespace Matrix
{
    public class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        //fields
        private T[,] matrix;
        private int defaultSize = 10;
        private int row;
        private int col;

        //properties
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        //indexer
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.row) || (col < 0 || col > this.col))
                {
                    throw new IndexOutOfRangeException("Try to access unexist element!");
                }
                return matrix[row, col];
            }

            set
            {
                if ((row < 0 || row > this.row) || (col < 0 || col > this.col))
                {
                    throw new IndexOutOfRangeException("Try to set value of unexist element!");
                }
                matrix[row, col] = value;
            }
        }

        //contructor
        public Matrix(int row, int col)
        {
            if (row == 0)
            {
                row = defaultSize;
            }
            if (col == 0)
            {
                col = defaultSize;
            }
            matrix = new T[row, col];
        }

        //predefined methods
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row != secondMatrix.Row) || (firstMatrix.Col != secondMatrix.Col))
            {
                throw new FormatException("The add of matrixes can not be used on matrixes with different sizes.");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row != secondMatrix.Row) || (firstMatrix.Col != secondMatrix.Col))
            {
                throw new FormatException("The substract of matrixes can not be used on matrixes with different sizes.");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }
            return resultMatrix;
        }



        public static Boolean operator true(Matrix<T> firstMatrix)
        {
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    if (firstMatrix[i, j].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> firstMatrix)
        {
            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    if (firstMatrix[i, j].Equals(0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
