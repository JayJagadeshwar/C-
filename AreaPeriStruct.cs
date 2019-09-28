 public struct structEx
    {
 
        public int TriArea(int height, int length)
        {
            Console.WriteLine("The Height of Triangle area is {0}", height);
            Console.WriteLine("The length of Triangle area is {0}", length);
            int area = (height * length) / 2;
            return area;

        }

        public int TriPerimeter(int side1, int side2, int side3)
        {
            Console.WriteLine("The side 1 of tringle is {0}", side1);
            Console.WriteLine("The side 2 of tringle is {0}", side2);
            Console.WriteLine("The side 3 of tringle is {0}", side3);
            int perimeter = side1 + side2 + side3;
            return perimeter;

        }


        public int RecArea(int length, int width)
        {
            Console.WriteLine("The length of the Rectangle is {0}", length);
            Console.WriteLine("The Width of the Rectangle is {0}", width);
            int area = length * width;
            return area;
        }


        public int RecPerimeter(int length, int width)
        {
            Console.WriteLine("The length of the Rectangle is {0}", length);
            Console.WriteLine("The Width of the Rectangle is {0}", width);
            int perimeter = 2 * (length + width);
            return perimeter;
        }

        public int SquArea(int side)
        {
            Console.WriteLine("The side of square is {0}", side);
            int area = 4 * side;
            return area;
        }

        public int Squperi(int side)
        {
           
            int peri = side * side;
            return peri;
        }

    }
    public class pro
    { 
        static void Main(string[] args)
        {
            structEx ex = new structEx();


            Console.WriteLine("Please enter 1 for triange or 2 for rec or 3 for square");
            int value = int.Parse(Console.ReadLine());


            if (value == 1)
            {
                Console.WriteLine("Please enter height and length values to find area of triangle");
                int trilen = int.Parse(Console.ReadLine());
                int triHei = int.Parse(Console.ReadLine());
                int res = ex.TriArea(triHei, trilen);
                Console.WriteLine(res);


                Console.WriteLine("Please enter the side1, side2, side3 of area to find perimeter");
                int side1 = int.Parse(Console.ReadLine());
                int side2 = int.Parse(Console.ReadLine());
                int side3 = int.Parse(Console.ReadLine());
                int res2 = ex.TriPerimeter(side1, side2, side3);
                Console.WriteLine(res2);
            }
            else if (value == 2)
            {
                Console.WriteLine("Please enter the length and width to find area and perimeter of rectangle");
                int reclen = int.Parse(Console.ReadLine());
                int recwid = int.Parse(Console.ReadLine());
                int res = ex.RecArea(reclen, recwid);
                int res1 = ex.RecPerimeter(reclen, recwid);
                Console.WriteLine(res);
                Console.WriteLine(res1);
            }
            else
            {
                Console.WriteLine("please enter the side of the square to find area and perimeter");
                int sqSide = int.Parse(Console.ReadLine());
                int res = ex.SquArea(sqSide);
                int res1 = ex.Squperi(sqSide);
                Console.WriteLine(res);
                Console.WriteLine(res1);
            }
            Console.ReadKey();
            
        }
    }