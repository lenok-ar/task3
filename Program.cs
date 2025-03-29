using System.Runtime.ExceptionServices;

namespace task3
{
    public class SquareMatrix
    {
        int[,] matrix = new int[5, 5];

        public void EnteringAndExportMatrix()
        {
            var rand = new Random();

            for (int row = 0; row < matrix.GetLength(0); ++row)
            {
                for (int col = 0; col < matrix.GetLength(1); ++col)
                {
                    matrix[row, col] = rand.Next(50);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); ++row)
            {
                for (int col = 0; col < matrix.GetLength(1); ++col)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static SquareMatrix operator +(SquareMatrix left, SquareMatrix right)
        {
            SquareMatrix result = new SquareMatrix();
            for (int row = 0; row < left.matrix.GetLength(0); ++row)
            {
                for (int col = 0; col < left.matrix.GetLength(1); ++col)
                {
                    result.matrix[row, col] = left.matrix[row, col] + right.matrix[row, col];
                }
            }
            return result;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                SquareMatrix matrix = new SquareMatrix();

                matrix.EnteringAndExportMatrix();
            }
        }
    }
}