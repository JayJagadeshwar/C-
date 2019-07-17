using System;
class AddSubMulDivUsingSwitch
{
    static void Main()
    {
        char ch;
        int iA=0, iB=0, iC=0;

    NumberRead:
        Console.WriteLine("Enter the A value and B value: ");
        iA = int.Parse(Console.ReadLine());
        iB = int.Parse(Console.ReadLine());

    charRead:
        Console.WriteLine("Enter the Char: ");
        ch = (char)Console.Read();
        Console.ReadLine();

        switch (ch)
        {
            case '+':
                iC = iA + iB;
                break;

            case '-':
                if(iB>iA)
                {
                    goto NumberRead;
                }
                else
                {
                    iC = iA - iB;
                }
                break;

            case '*':
                if (iB != 0)
                {
                    iC = iA * iB;
                }
                else
                {
                    goto NumberRead;
                }
                break;
            case '/':
                if(iB!=0)
                {
                    iC = iA / iB;
                }
                else
                {
                    goto NumberRead;
                }
                break;
            default:
                goto charRead;
        }
        Console.WriteLine("the result is {0} ", iC);
        Console.ReadKey();
    }
}



