    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar) {
        int maxSum = 0;
        int tmp = 0;
        foreach (int elt in ar) {
            if (elt > tmp)
            {
                tmp = elt;
                maxSum = 1;
            }
            else if (elt == tmp) {
                maxSum += 1;
            }
        }
        return maxSum;
    }
