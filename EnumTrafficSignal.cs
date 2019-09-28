class Program
    {
        enum TrafficSignals
        {
            Red = 1,
            Yellow =2,
            Green=3,
        }


        static void Main(string[] args)
        {
            foreach (string str in Enum.GetNames(typeof(TrafficSignals)))
            {
                Console.WriteLine(str);
            }


            Console.WriteLine("Please enter 1 for red or 2 for Yellow or 3 for Green");
            int iSignal = int.Parse(Console.ReadLine());


            switch(iSignal)
            {
                case 1:
                    Console.WriteLine("Please Stop while Red signal is displayed");
                    break;
                case 2:
                    Console.WriteLine("Please Get Ready to move");
                    break;
                case 3:
                    Console.WriteLine("Ready to move");
                        break;

            }
            Console.ReadKey();
        }
    }