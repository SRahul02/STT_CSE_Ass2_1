using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Op_on_Arrays
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int flg = 0;
            for (int i=0; i<n-1; i++) {
                flg = 0;
                for (int j=0;j<n-1-i; j++) {
                    if (arr[j] > arr[j + 1]) {
                        flg = 1;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if (flg == 0) { break; }
            }
        }

        public static void PrintArray(string title, int[] arr)
        {
            Console.WriteLine($"\n--- {title} ---");
            Console.WriteLine(string.Join(", ", arr));
        }

        public static int[] By_Row_2d_to_1d(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] arr = new int[rows * cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    int ind = (i*cols) + j;
                    arr[ind] = matrix[i, j];
                }
            }
            return arr;
        }

        public static int[] By_Col_2d_to_1d(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] arr = new int[rows * cols];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    int ind = (j * rows) + i;
                    arr[ind] = matrix[i, j];
                }
            }
            return arr;
        }

        public static int[,] Multiply_matrices(int[,] A, int[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            if (colsA != rowsB) // Matrics not multipliable !
            {
                Console.WriteLine("Cannot multiply matrices.");
                Console.WriteLine("Columns in Matrix A must equal Rows in Matrix B.");
                return null; // 'null' means "no object"
            }

            int[,] C = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++) {
                for (int j = 0; j < colsB; j++) {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += (A[i, k] * B[k, j]);
                    }
                    C[i, j] = sum;
                }
            }

            return C;
        }

        public static void PrintMatrix(string title, int[,] matrix)
        {
            Console.WriteLine($"\n--- {title} ---");

            if (matrix == null) {
                Console.WriteLine("Matrix is null.");
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) {
                Console.Write("[ ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(4));
                }
                Console.WriteLine("]");
            }
        }
    }
}
