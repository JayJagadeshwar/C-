using System;

class Tableprinting
{
    static void Main()
    {
        int iNo, iSize;
        Console.WriteLine("Enter the number: ");
        iNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the size of the table: ");
        iSize = int.Parse(Console.ReadLine());

        int i = 1;
        do
        {
            string str;
            str = iNo + "*" + i +"=" + (iNo * i);
            Console.WriteLine(str);
            i++;
        } while (i <= iSize);

        Console.ReadKey();

    }
  
}   