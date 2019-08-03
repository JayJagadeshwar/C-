using System;

class PalindromeInt
{
    static void Main()
    {
        int iNo, iS = 0, iR, iT;
        Console.WriteLine("Enter the number: ");
        iNo = int.Parse(Console.ReadLine());
        iT = iNo;
        while (iNo > 0)
        {
            iR = iNo % 10;
            iS = (iS * 10) + iR;
            iNo = iNo / 10;
        }
        if (iS == iT)
        {
            Console.WriteLine("the number {0} is a palindrome", iT);
        }
        else
        {
            Console.WriteLine("the number {0} is not a palindrome", iT);
        }
        Console.ReadKey();
    }
}
