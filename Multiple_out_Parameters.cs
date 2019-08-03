using System;

class Multiple_out_Parameters
{
    public static void parameters(int num1, int num2, out int sum, out int diff, out int mul, out float div)
    {
        sum = num1 + num2;
        diff = num1 - num2;
        mul = num1 * num2;
        div = (float)num1 / num2;
    }

    public static void Main()
    {
        int num1, num2;
        int sum, diff, mul;
        float div;

        Console.WriteLine("Please enter the first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        Multiple_out_Parameters.parameters(num1, num2, out sum, out diff, out mul, out div);

        Console.WriteLine("Sum of {0} + {1} = {2}", num1, num2, sum);
        Console.WriteLine("diff of {0} - {1} = {2}", num1, num2, diff);
        Console.WriteLine("mul of {0} * {1} = {2}", num1, num2, mul);
        Console.WriteLine("div of {0} / {1} = {2}", num1, num2, div);

    }
}