	// Complete the miniMaxSum function below.
    	static void miniMaxSum(int[] arr) {
        	long a = 0, b = 0;

        	Array.Sort(arr);

       		for ( int i = 0; i < arr.Length; i++ ) {
            		a += (i == 0) ? 0 : arr[i];
            		b += (i == arr.Length - 1) ? 0 : arr[i];
        	}

        	Console.WriteLine(b+" "+a);
	
	}
