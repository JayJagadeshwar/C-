using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggu
{
    class StudentBatch
    {
        public static void Main()
        {
            Dictionary<string,string> stu = new Dictionary<string, string>();
            stu.Add("Jay", "Computers");
            stu.Add("Rohith", "Electrical");
            stu.Add("Vineeth", "Electronics");
            stu.Add("Stella", "Hacking");
            stu.Add("Janani", "Sciences");

            Dictionary<string, string> stud = new Dictionary<string, string>();
            stud.Add("Vikram", "Maths");
            stud.Add("Ajay", "Microprocesrs");
            stud.Add("John", "HumanValues");
            stud.Add("Maroon", "DigitalForensic");
            stud.Add("Jason", "cyberSecurity");

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("steve", "WebDevelopment");
            st.Add("Rakesh", "java");
            st.Add("Mike", "Mechanics");
            st.Add("Smith", "MeterialScience");
            st.Add("Carl", "CommunicationTech");


            foreach (var item in stu)
            {
                Console.WriteLine("Batch1 students and their subjects: " + item);
            }

            Console.WriteLine("\n");
            foreach (var item in stud)
            {
                Console.WriteLine("Batch2 Students and their subjects: " + item);
            }

            Console.WriteLine("\n");
            foreach (var item in st)
            {
                Console.WriteLine("Batch3 students and their subjects: "+ item);
            }

            Console.ReadKey();
        }
    }
}
