 class JaggedArrays
    {
        public static void Main()
        {
            int[][] student = new int[3][];
            
            student[0] = new int[3] { 65, 60, 76 };
            student[1] = new int[5] { 78, 92, 68, 90, 55 };
            student[2] = new int[4] { 45, 59, 88, 72 };

            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < student[i].Length; j++)
                {
                    Console.Write(student[i][j]+"\t");
                  
                }
                Console.Write("\n");
            }

            Console.ReadKey();


        }
    }