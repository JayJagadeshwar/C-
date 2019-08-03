using System;
struct student
    {
        public int iSid;
        public string strSname;
    }
    class StructExample
    {
        static void Main()
        {
            student sobj;
            Console.WriteLine("Enter the student id: ");
            sobj.iSid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student name: ");
            sobj.strSname = Console.ReadLine();
            int iMaths, iScience, iSocial;
            float fTotal, fAverage;
            Console.WriteLine("Enter the maths, science and social marks: ");
            iMaths = int.Parse(Console.ReadLine());
            iScience = int.Parse(Console.ReadLine());
            iSocial = int.Parse(Console.ReadLine());
            fTotal = iMaths + iSocial + iScience;
            fAverage = fTotal / 3;
            Console.WriteLine("the student id{0}, and student name {1} total marks is {2} and average is {3}", sobj.iSid, sobj.strSname, fTotal, fAverage);
        }
    }