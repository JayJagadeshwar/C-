class ArraySorting
    {
        public static void Main()
        {
            string[] arr = new string[5]
            {
                "F_Jay","B_Rohith", "A_Vineeth","G_Ranjith","J_Stella"
            };

            
            foreach (var item in arr)
            {
                Console.WriteLine("Students are:"+item);
                
            }



            Console.WriteLine("Array after sort");
            Array.Sort(arr);
            foreach (var item in arr)
            {

                Console.WriteLine("Sorted names:"+item);
            }


            int i;
            Array.Reverse(arr);
            for (i = 0; i < arr.Length; i++)
            {
               
                Console.WriteLine("Reverse list of names: "+arr[i]);
            }


            ReadMe:
            Console.WriteLine("Enter the index number to display the name in array");
            int index = int.Parse(Console.ReadLine());
            
            if (index < arr.Length)
            {
                Console.WriteLine(arr[index]);
            }
            else
            {
                Console.WriteLine("Please enter the proper index value");
                goto ReadMe;
            }

            
            
            Console.ReadKey();
        }
    }