    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        double p = 0, n = 0;
        double len = arr.Length;

        for (int i = 0; i < len; i++) {
            if (arr[i] > 0)
            {
                p++;
            }
            else if (arr[i] < 0) {
                n++;
            }
        }
        Console.WriteLine("{0:F6}", p/len);
        Console.WriteLine("{0:F6}", n/len);
        Console.WriteLine("{0:F6}", (len - (n + p)) / len);
        
    }
