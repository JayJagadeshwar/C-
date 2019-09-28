class Program
    {
        static void Main(string[] args)
        {
            StringCollection strColl = new StringCollection();
           

            ArrayList arrobj = new ArrayList();
            Console.WriteLine("Enter the number of values you want to enter");
            int iValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < iValue; i++)
            {
                string strvalue = null;
                strvalue = Console.ReadLine();
                arrobj.Add(strvalue);
                arrobj.AddRange(strColl);
            }

            Console.WriteLine();
            Console.WriteLine("The final list of items are:");
            foreach (var item in arrobj)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }