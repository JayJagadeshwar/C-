class Program
    {
        

        static void Main(string[] args)
        {
            ReadMe:
            double a,b;
            Console.WriteLine("Enter a value: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value: ");
            b = double.Parse(Console.ReadLine());
            double div;

            try
            {
                div = a / b;
                Console.WriteLine("division is " + div);
                goto ReadMe;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }