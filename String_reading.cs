using System;


    class String_reading
    {
        static void Main(string[] args)
        {
            string StrValue;
            Console.WriteLine("enter the string value:");
            StrValue = Console.ReadLine();
            int iA;
            float iF;
            double iD;
            Console.WriteLine("enter the iA value:");
            iA = int.Parse(Console.ReadLine());
            Console.WriteLine("enter iF value:");
            iF = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the iD value:");
            iD = double.Parse(Console.ReadLine());
            Console.WriteLine("value of string: {0}, value of int:{1}, value of float:{2}, value of double:{3}", StrValue, iA, iF, iD);
            Console.ReadKey();
        }
    }
