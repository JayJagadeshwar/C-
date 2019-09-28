class PowerValue
    {
        public int Power(int num, int exp)
        {
            int value = 1;
            for (int i = 0; i < exp; i++)
            {
                value = value * num;
            }
            return value;
        }


        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine("Enter base number: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exp number");
            int exp = int.Parse(Console.ReadLine());
            int res = p.Power(base1, exp);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }