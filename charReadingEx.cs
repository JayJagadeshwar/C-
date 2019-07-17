using System;
    class charReadingEx
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the value "); //Reading character dynamically by using Console.Readread() function.
            ch = (char)Console.Read();      //ReadKey is used for reading only one single char.
            Console.WriteLine("char is " + ch);   
            Console.ReadKey();   
        }
    }
