using System;
class FindMaxValue
{
    static void Main()
    {
        int iA, iB, iMax;
        Console.WriteLine("enter the iA and iB value: ");
        iA = int.Parse(Console.ReadLine());
        iB = int.Parse(Console.ReadLine());
        iMax = iA > iB ? iA : iB;
        Console.WriteLine("the maximum value is :"+ iMax );
        Console.ReadKey();

    }
}

