using System;
namespace ReverseOfAnArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a size of an array");
            int size = int.Parse(Console.ReadLine());
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter index{0}", i);
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("numbers in array");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            for (int i = size-1; i >= 0; i--)
            {
                Console.WriteLine("reverse{0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}
