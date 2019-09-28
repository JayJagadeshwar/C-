class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter the 10 numbers one by one");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine("The number {0} is odd", numbers[i]);
                }
                else
                {
                    Console.WriteLine(" number {0} is even ", numbers[i]);                    
                }
            }

            Console.ReadKey();
        }
    }