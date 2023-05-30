int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 6, 6, 6, 6 };
int[] freq = new int[arr.Length];
int maxFreq = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            freq[i] = count;

            if (count > maxFreq)
            {
                maxFreq = count;
            }
        }
        Console.Write("The element(s) that occur most frequently: ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (freq[i] == maxFreq)
            {
                Console.Write(arr[i] + " ");
            }
        }
