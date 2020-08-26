    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int val = arr.Count;
        int a = 0, b = 0;

        for (int i = 0; i < val; i++)
        {
            a += arr[i][i];
            b += arr[i][val - 1 - i];
            
        }
        return Math.Abs(a - b);
    }
