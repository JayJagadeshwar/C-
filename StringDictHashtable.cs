class Program
    {
        static void Main(string[] args)
        {
            StringDictionary myDict = new StringDictionary();

         
            myDict.Add("A", "Apple");
            myDict.Add("X", "Banana");
            myDict.Add("C", "Cat");
            myDict.Add("Z", "Dog");
            myDict.Add("J", "Elephant");

            Console.WriteLine("Values after Sorting a string dictionary");
            foreach (DictionaryEntry entry in myDict)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }
            


            Console.WriteLine();
            Hashtable ht = new Hashtable();
            ht.Add("#005", ".Net");
            ht.Add("#002", "C#");
            ht.Add("#8", "ASP.Net");
            ht.Add("#3", "ASP.Net Mvc");
            ht.Add("#4", "ASP.Net Core");
            ht.Add("#1", "Java");
            ICollection keys = ht.Keys;
            Console.WriteLine("Values after sorting a hash table Keys");
            foreach (String k in keys)
            {
                Console.WriteLine("Key is:"+k+"Key vlaue is:"+ht[k]);
            }




            Console.WriteLine();
            List<string> lst = new List<string>();
            foreach (var key2 in ht.Keys)
            {
                lst.Add(key2.ToString());
            }
            lst.Sort();
            Console.WriteLine("Values before sorting in a hash table ");
            foreach (var item in lst)
            {
                Console.WriteLine(string.Format("{0},{1}", item, ht[item.ToString()]));
            }



            Console.ReadKey();
        }
    }