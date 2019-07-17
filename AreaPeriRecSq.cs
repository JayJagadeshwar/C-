using System;


    class AreaPeriRecSq
    {
    static void Main(string[] args)
    {
        //finding the Area, Peri of Rec and Area, Peri of Square
        int iL, iB, iS;
        Console.WriteLine("Enter the length and Breadth value : ");
        iL = int.Parse(Console.ReadLine());
        iB = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the side value :");
        iS = int.Parse(Console.ReadLine());
        float fAreaRec, fAreaSq, fPeriRec, fPeriSq;
        fAreaRec = iL * iB;
        fAreaSq = iS * iS;
        fPeriRec = (2 * (iL + iB));
        fPeriSq = 4 * iS;
        Console.WriteLine("Area of Rec{0}, Peri of Rec{1}", fAreaRec, fPeriRec);
        Console.WriteLine("Area of sq{0}, Peri of sq{1}", fAreaSq, fPeriSq);
        Console.ReadKey();


    }
}

