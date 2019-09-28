class ArrayAddIndexes

    {
        public static void Main()
        {
            int[] arr = new int[5];
            int res = 0;

            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                res = res + arr[i];
            }

            Console.WriteLine("{0}",res);
            Console.ReadKey();
        }
    }