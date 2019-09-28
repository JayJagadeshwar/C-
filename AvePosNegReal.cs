class AvePosNegReal
    {
        static void Main()
        {
            float[] inputreal = new float[10];
            float fAvePositive = 0;
            float fAveNegitive = 0;
            int iCountPositive = 0;
            int iCountNegative = 0;
            Console.WriteLine("Enter any 10 real numbers");
            for (int i = 0; i < 10; i++)
            {
                inputreal[i] = float.Parse(Console.ReadLine());
                if (inputreal[i] > 0)
                {
                    fAvePositive = fAvePositive + inputreal[i];
                    iCountPositive++;
                }
                else if (inputreal[i] < 0)
                {
                    fAveNegitive = fAveNegitive + inputreal[i];
                    iCountNegative++;
                }
            }
            Console.WriteLine("The average of positive numbers is {0}", fAvePositive/iCountPositive);
            Console.WriteLine("The average of negitive numbers is {0}", fAveNegitive/iCountNegative);


            Console.ReadKey();
        }
    }