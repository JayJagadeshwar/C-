using System;


namespace delegatess
{

    public delegate void Mydelegate();

    class delegates
    {
        public static void helloworld()
        {
            Console.WriteLine("Hi, HelloWorld!");
           
        }

        public static void addition(Mydelegate action,int x, int y)
        {
            action();
            Console.WriteLine("The sum of {0} and {1} is: {2}",x, y, x+y);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate del = new Mydelegate(delegates.helloworld);
            

            delegates.addition(delegates.helloworld, 30, 20);

            Console.ReadKey();
        }
        
    }
}
