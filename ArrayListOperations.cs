 class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrylist = new ArrayList();
            arrylist.Add("Jay");
            arrylist.Add("Rohith");
            arrylist.Add("Vineeth");
            arrylist.Add("Stella");


            Console.WriteLine("Data in the list");
            foreach (var item in arrylist)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Enter the number of values you want to insert");
            int iValues = int.Parse(Console.ReadLine());
            var array = new string[iValues];
            Console.WriteLine("Enter the Values: ");
            for (int i = 0; i < array.Length; i++)
            {
                string vari = null;
                vari = Console.ReadLine();
                array[i] = vari;
                arrylist.Add(vari);
            }
            Console.WriteLine("After addding range of values");
            foreach (var item in arrylist)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("Please enter delete option to delete=> 1)Single Name, 2)Range of names, 3)exit");
            int enteredNo = int.Parse(Console.ReadLine());
            if (enteredNo == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a index value to remove from list");
                int remove = int.Parse(Console.ReadLine());
                arrylist.RemoveAt(remove);
                Console.WriteLine("After deleting the list of names");
                foreach (var item in arrylist)
                {
                    Console.WriteLine(item);
                }
            }
            else if (enteredNo == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the starting index");
                int istart = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Last index");
                int iend = int.Parse(Console.ReadLine());
                arrylist.RemoveRange(istart, iend);
                Console.WriteLine("After deleting the list of names");
                foreach (var item in arrylist)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }