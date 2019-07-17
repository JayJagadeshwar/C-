using System;
class VowelOrConsonent
{
    static void Main()
    {
        char ch;
        Console.WriteLine("enter the char: ");
        ch = (char)Console.Read();
        string strResult = (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') ? "vowel" : "consonent";
        Console.WriteLine(strResult);
        Console.ReadKey();
    }
}

