using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTest
    {

        public static void PrintMatrix(Matrix<T> resultMatrix)
        {
            for (int i = 0; i < resultMatrix.Row; i++)
            {
                for (int j = 0; j < resultMatrix.Col; j++)
                {
                    Console.WriteLine(resultMatrix[i, j].ToString() + ' ');
                }
            }
        }

        static void Main()
        {
            Matrix<int> testIntMatrixOne = new Matrix<int>(5, 7);
            Matrix<int> testIntMatrixTwo = new Matrix<int>(5, 7);
            //Matrix.PrintMatrix(testIntMatrix);
            Matrix<int> result = new Matrix<int>(5, 7);
            Console.WriteLine("Matrix test");
            result = (testIntMatrixOne + testIntMatrixTwo);

            int k = 0;
            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = k;
                    k++;
                }
            }
            PrintMatrix(result);
        }
            
       
    }
}
