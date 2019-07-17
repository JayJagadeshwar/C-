using System;


    class Adding_two_number
    {
        static void Main(string[] args)
        {
        int iA, iB, iC;
        Console.WriteLine("enter the iA value: ");
        iA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the iB value: ");
        iB = int.Parse(Console.ReadLine());
        iC = iA + iB;
        Console.WriteLine("the sum is : {0} ", iC);
        Console.ReadKey();

        }
    }

