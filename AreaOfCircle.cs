using System;
    class AreaOfCircle
    {
    static void Main(string[] args)
    {
        //finding area of a circle = pi r square
        const float fpi = 3.14f;
        float fRadius;
        Console.WriteLine("enter the radius: ");
        fRadius = float.Parse(Console.ReadLine());
        float fCircleArea;
        fCircleArea = fpi * fRadius * fRadius;
        Console.WriteLine("the area of a circle is: " + fCircleArea);
        Console.ReadKey();
    }
    }

