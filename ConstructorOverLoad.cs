class ConstuctorOverLoad
    {
        int Height, width;
        public ConstuctorOverLoad(int a, int b)
        {
            Height = a;
            width = b;
        }

        public ConstuctorOverLoad(int x)
        {
            Height = x;
            width = x;
        }

        public void Show()
        {
            Console.WriteLine("Height is :"+ Height);
            Console.WriteLine();
            Console.WriteLine("width is: "+ width);
        }


        static void Main()
        {
            ConstuctorOverLoad c1 = new ConstuctorOverLoad(20, 30);
            c1.Show();
            ConstuctorOverLoad c2 = new ConstuctorOverLoad(50);
            c2.Show();
            Console.ReadKey();
        }
            
    }