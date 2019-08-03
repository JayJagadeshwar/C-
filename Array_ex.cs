using System;
using System.Collections.Generic;
public class Array_ex
{

    static void Main()
    {
        int[] number = new int[5] ;
        int i;

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a number: ");
            number[i] = int.Parse(Console.ReadLine());
        }



        for (i = 0; i < 5; i++)
        {
            int array = number[i];
            Console.WriteLine(number[i]);
        }
       
        Console.ReadKey();
    }
    



}