public class Kata
{
    public static int[][] MatrixAddition(int[][] a, int[][] b)
    {
        int rows = a.Length;
        int cols = a[0].Length;

        int[][] result = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            result[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                result[i][j] = a[i][j] + b[i][j];
            }
        }

        return result;
    }
}