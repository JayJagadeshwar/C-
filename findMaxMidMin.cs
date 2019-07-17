using System;
class findMaxMidMin
{
    static void Main(string[] args)
    {
        int iA, iB, iC, iMax = 0, iMid = 0, iMin = 0;
    Enter:
        Console.WriteLine("Enter the a,b,c values : ");
        iA = int.Parse(Console.ReadLine());
        iB = int.Parse(Console.ReadLine());
        iC = int.Parse(Console.ReadLine());
        if (iA == iB || iB == iC || iC == iA || iB ==iA || iC == iB || iA ==iC)
        {
            goto Enter;
        }
        else
        {
            if (iA > iB && iA > iC)
            {
                iMax = iA;
                if (iB > iC)
                {
                    iMid = iB;
                    iMin = iC;
                }
                else
                {
                    iMid = iC;
                    iMin = iB;
                }
                goto PrintMaxMidMin;
            }


            else if (iB > iA && iB > iC)
            {
                iMax = iB;
                if (iA > iC)
                {
                    iMid = iA;
                    iMin = iC;
                }
                else
                {
                    iMid = iC;
                    iMin = iA;
                }
                goto PrintMaxMidMin;
            }

            else
            {
                iMax = iC;
                if (iB> iA)
                {
                    iMid = iB;
                    iMin = iA;
                }
                else
                {
                    iMid = iA;
                    iMin = iB;
                }
                goto PrintMaxMidMin;
            }

        }
        PrintMaxMidMin:
        Console.WriteLine("max value is {0}, mid valule is{1}, min value is {1}", iMax, iMid, iMin);
        Console.ReadKey();
    }
}



