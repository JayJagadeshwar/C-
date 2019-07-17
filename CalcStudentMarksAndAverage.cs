using System;
class CalcStudentMarksAndAverage
{
    static void Main()
    {
        int iSid;
        ReadMe :
        Console.WriteLine("Enter the student Id: ");
        iSid = int.Parse(Console.ReadLine());
        bool bResult;
        if (iSid==121)
        {
            bResult = true;
        }
        else if(iSid==122)
        {
            bResult = true;
        }
        else if (iSid==123)
        {
            bResult = true;
        }
        else
        {
            goto ReadMe;
        }
        if (bResult == true)
        {
            float iScience, iSocial, iMaths;
            Console.WriteLine("enter the Science, social, Maths marks: ");
            iScience = float.Parse(Console.ReadLine());
            iSocial = float.Parse(Console.ReadLine());
            iMaths = float.Parse(Console.ReadLine());
            float fResult = iScience + iSocial + iMaths;
            float fAverage = fResult / 3;
            Console.WriteLine("the result of this student is {0}, and average is {1}", fResult, fAverage);
        }
        Console.ReadKey();
    }
}

