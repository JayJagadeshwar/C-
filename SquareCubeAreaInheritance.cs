using System;

namespace jaggu
{
    class Square
    {
        public virtual int Area(int side)
        {
            
            return side * side;
        }
    }

    class Cube : Square
    {
        public override int Area(int side)
        {
           
            return 6 * side * side;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Squre side");
            int side = int.Parse(Console.ReadLine());
            Square sq = new Square();
            Console.WriteLine("Area of square is: "+sq.Area(side));

            Console.WriteLine("cube side");
            int sid = int.Parse(Console.ReadLine());
            Cube cu = new Cube();
            Console.WriteLine("Area of a cube is: " + cu.Area(sid));
            Console.ReadKey();
        }
    }
}
