using System;

class Val_Ref_Ex

{
    public static void Value(int num)
    {
        num++;
    }

    public static void Referrence(ref int num1)
    {
        num1++;
    }

    public static void Main()
    {
        int num, num1;
        Console.WriteLine("Enter the num: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the num1: ");
        num1 = int.Parse(Console.ReadLine());
        Val_Ref_Ex.Value(num);
        Val_Ref_Ex.Referrence(ref num1);
        Console.WriteLine(num);
        Console.WriteLine(num1);
        Console.ReadKey();
    }

}