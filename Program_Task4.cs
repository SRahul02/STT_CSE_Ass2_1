namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            Op_on_Arrays.PrintArray("Unsorted Array", unsortedArray);
            Op_on_Arrays.BubbleSort(unsortedArray);
            Op_on_Arrays.PrintArray("Sorted Array (Bubble Sort)", unsortedArray);

            // Testing 2d to 1d conversion of array by both row major and col major order
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Op_on_Arrays.PrintMatrix("2D Matrix (for conversion)", matrix);

            int[] rowMajor = Op_on_Arrays.By_Row_2d_to_1d(matrix);
            Op_on_Arrays.PrintArray("1D Array (Row-Major)", rowMajor);

            int[] colMajor = Op_on_Arrays.By_Col_2d_to_1d(matrix);
            Op_on_Arrays.PrintArray("1D Array (Column-Major)", colMajor);

            // 3. Test Matrix Multiplication
            int[,] matrixA = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            }; // (2 rows, 3 cols)

            int[,] matrixB = {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            }; // (3 rows, 2 cols)

            Op_on_Arrays.PrintMatrix("Matrix A", matrixA);
            Op_on_Arrays.PrintMatrix("Matrix B", matrixB);

            int[,] matrixC = Op_on_Arrays.Multiply_matrices(matrixA, matrixB);
            Op_on_Arrays.PrintMatrix("Result Matrix C (A * B)", matrixC);
        }
    }
}
