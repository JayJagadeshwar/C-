using System;

class Out_Parameter

{
    public static void rectangle(int width,int length, out int area, out int paremeter) 
        {
        area = width * length;
        paremeter = 2 * (length + width);
        }


    public static void Main()
    {
        int area, paremeter;
        Out_Parameter.rectangle(3, 5, out area, out paremeter);
        Console.WriteLine(area);
        Console.WriteLine(paremeter);
        Console.ReadKey();
    }
}