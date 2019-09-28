class ThreadCount
    {
        public static void Thread1()
        {
            int count = 0;
            while (count++ < 10)
            {
                Console.WriteLine("Thread is running: {0}", count);
                Thread.Sleep(1000);
                Console.WriteLine();
            }
        }

       
        public static void Thread2()
        {
            int count = 0;
            while (count++ < 10)
            {
                Console.WriteLine("Thread is running: {0}", count);
                Thread.Sleep(1000);
                Console.WriteLine();
            }
           
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(ThreadCount.Thread1));
            Thread t2 = new Thread(new ThreadStart(ThreadCount.Thread2));
            t1.Start();
            Console.WriteLine("Thread one state is {0}",t1.ThreadState);
            t2.Start();
            Console.WriteLine("Thread two state is {0}", t2.ThreadState);

            Console.ReadKey();
        }
    }