using System;
class CustomerProducts
{
    static void Main()
    {
        double dQun, dPrice;
        Console.WriteLine("Enter the Quantity: ");
        dQun = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Price: ");
        dPrice = double.Parse(Console.ReadLine());

        int ipId;
    ReadMe:
        Console.WriteLine("Enter the Product id: ");
        ipId = int.Parse(Console.ReadLine());

        double dTotal=0;
        string strProductName = "";

        switch (ipId)
        {
            case 121:
                strProductName = "consumer Product";
                dTotal = dQun * dPrice;
                goto CategoryPrint;
                break;

            case 122:
                strProductName = "medical Product";
                dTotal = dQun * dPrice;
                goto CategoryPrint;
                break;

            case 123:
                strProductName = "Electronnics Product";
                dTotal = dQun * dPrice;
                goto CategoryPrint;
                break;

            default:
                goto ReadMe;

        }
    CategoryPrint:
        Console.WriteLine("the product name is {0}, \n the product id is {1}, \n total is {2}", strProductName, ipId, dTotal);
        Console.ReadKey();

    }
}