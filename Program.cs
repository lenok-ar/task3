using System.Runtime.ExceptionServices;

namespace task3
{
  public class SquareMatrix
  {
    int[,] matrix = new int[5, 5];

    public void EnteringAndExportMatrix()
    {
      var rand = new Random();

      for (int rows = 0; rows < matrix.GetLength(0); ++rows)
      {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            matrix[rows, cols] = rand.Next(50);
        }
      }

      for (int rows = 0; rows < matrix.GetLength(0); ++rows)
      {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write(matrix[rows,cols] +"\t");
        }
        Console.WriteLine();
      }
    }
  }

    internal class  Program
    {
        static void Main(string[] args)
        {
            SquareMatrix matrix = new SquareMatrix();   

            matrix.EnteringAndExportMatrix();
        }
    }
}