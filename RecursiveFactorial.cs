 class RecursiveFactorial
    {
       public int recursive(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                int m = n * recursive(n - 1);
                return m;
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine(p.recursive(x));
            Console.ReadKey();
        }
    }