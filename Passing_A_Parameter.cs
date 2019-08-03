using System;

class Passing_A_Parameter
{

    public static int Power(int num)
    {
        int result;
        result = num * num;
        return result;
    }

    public float jay(float num1, float num2)
    {
        float result1;
        result1 = num1 / num2;
        return result1;
    }


    public static void Main()
    {
        float a, b;
        int c;
        Console.WriteLine("Enter a value: ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter b value: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for static parameter passing: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine(Passing_A_Parameter.Power(c));

        Passing_A_Parameter p1 = new Passing_A_Parameter();
        Console.WriteLine(p1.jay(a, b));
    }
}