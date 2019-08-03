using System;

class FindMaxInAGivenNumber

{
    public int FindMax(int x, int y)
    {
        int result;
        if (x > y)
            result = x;
        else
            result = y;
        return result;
    }

    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter the a value: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the b value: ");
        b = int.Parse(Console.ReadLine());
        FindMaxInAGivenNumber p = new FindMaxInAGivenNumber();
        int ret = p.FindMax(a,b);
        Console.WriteLine("Maxmum value is: {0}", ret);
        Console.ReadKey();

    }
    
}