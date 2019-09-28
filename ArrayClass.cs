class ArrayClass
    {


        int value1;
        int value2;
        int value3;

        public ArrayClass()
        {
            
            Console.WriteLine("Enter value1: ");
            int val1 = int.Parse(Console.ReadLine());
            value1 = val1;

            Console.WriteLine("Enter value2: ");
            int val2 = int.Parse(Console.ReadLine());
            value2 = val2;

            Console.WriteLine("Enter value3: ");
            int val3 = int.Parse(Console.ReadLine());
            value3 = val3;

        }

        int[] values;

        public int Value1 { get => value1; set => value1 = value; }
        public int Value2 { get => value2; set => value2 = value; }
        public int Value3 { get => value3; set => value3 = value; }

        public void AddValues()
        {
            values = new int[3];
            values[0] = Value1;
            values[1] = Value2;
            values[2] = Value3;

            foreach (var item in values)
            {
                Console.WriteLine("Values are: "+ item);
            }


            Array.Reverse(values);
            Array.Reverse(values);
            foreach (var item in values)
            {
                Console.WriteLine("Double Reversed array: "+item);
            }

            Console.WriteLine();
            Array.Clear(values,0,1);   
            Console.WriteLine("After clearing values: "+ values[2]);
                
            
        }

        

        public static void Main()
        {
            ArrayClass arrobj = new ArrayClass();
            arrobj.AddValues();
            Console.ReadKey();
        }

    }