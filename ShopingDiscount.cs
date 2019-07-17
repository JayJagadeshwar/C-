using System;
class ShopingDiscount
{
    static void Main()
    {
        string strShopName;
        double dQun, dPrice, dDiskAllow, dDiskCal, dGross, dNet;
        bool bResult;
        Console.WriteLine("enter the shop name: ");
        strShopName = Console.ReadLine();
        Console.WriteLine("enter the quantity :");
        dQun = double.Parse(Console.ReadLine());
        Console.WriteLine("enter the price :");
        dPrice = double.Parse(Console.ReadLine());
        if (strShopName == "chermas")
        {
            dDiskAllow = 0.30;
            bResult = true;
        }
        else if (strShopName == "stopper shop")
        {
            dDiskAllow = 0.25;
            bResult = true;
        }
        else if (strShopName == "pantaloons")
        {
            dDiskAllow = 0.15;
            bResult = true;
        }
        else
        {
            dDiskAllow = 0.0;
            bResult = false;
        }
        dGross = dQun * dPrice;
        if (bResult == true)
        {
            dDiskCal = dGross * dDiskAllow;
            dNet = dGross - dDiskCal;
            Console.WriteLine("shop name:{0} \n Discount calculation :{1} \n gross Total:{2}", strShopName, dDiskCal, dGross);
        }
        else
        {
            dNet = dGross;
            Console.WriteLine("shop name:{0}, \n gross total:{1}, \n net total:{2}", strShopName, dGross, dNet);
            Console.ReadKey();
        }
    }
}

