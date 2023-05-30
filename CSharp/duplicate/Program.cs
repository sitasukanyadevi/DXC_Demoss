int[] arr = new int[10];
            Console.WriteLine("Enter the elements");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"count of dupicate value is {count}");