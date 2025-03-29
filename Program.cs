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

  public static SquareMatrix operator + (SquareMatrix left, SquareMatrix right)
  { 
    SquareMatrix result = new SquareMatrix();
    for (int row = 0; row < left.matrix.GetLength(0); row++)
    {
      for (int col = 0; col < left.matrix.GetLength(1); col++)
      {
        result.matrix[row, col] = left.matrix[row, col] + right.matrix[row, col];
      }
    }
    return result;
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