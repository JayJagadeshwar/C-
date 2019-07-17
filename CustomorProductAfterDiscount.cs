using System;
class CustomorProductAfterDiscount
{
    static void Main()
    {
        double dQun, dPrice, dCustId;
    CustomerId:
        Console.WriteLine("Enter the Customer id: ");
        dCustId = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the quantity: ");
        dQun = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Price of the product: ");
        dPrice = double.Parse(Console.ReadLine());
  

        double ipId;
    Readme:
        Console.WriteLine("Enter the product id: ");
        ipId = double.Parse(Console.ReadLine());
        double dTotal=0;
        string strProductName = "";
        double dDiscount;
        double dGross;

        int PayPinNo;
        string BankAccount;
        int SelectBankType;
    BankDetails:
        Console.WriteLine("Press 1 for PrivateBank or Press 2 for Public Bank type: ");
        SelectBankType = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Bank Account Name: ");
        BankAccount = Console.ReadLine();

        Console.WriteLine("Enter the Pin number to pay: ");
        PayPinNo = int.Parse(Console.ReadLine());


        if (SelectBankType == 1 || SelectBankType == 2 && BankAccount == "PrivateBank" || BankAccount == "PublicBank")
        {

            switch (ipId)
            {

                case 1000:
                    if (dCustId >= 2000 && dCustId <= 3000)
                    {

                        strProductName = "medical Product";
                        dTotal = dQun * dPrice;
                        dDiscount = dTotal * 0.30;
                        dGross = dTotal - dDiscount;
                        goto ProductPrint;
                    }
                    else
                    {
                        goto CustomerId;
                    }
                    break;


                case 2000:
                    if (dCustId >= 2000 && dCustId <= 3000)
                    {
                        strProductName = "electronics Product";
                        dTotal = dQun * dPrice;
                        dDiscount = dTotal * 0.30;
                        dGross = dTotal - dDiscount;
                        goto ProductPrint;
                    }
                    else
                    {
                        goto CustomerId;
                    }
                    break;

                case 3000:
                    if (dCustId >= 2000 && dCustId <= 3000)
                    {
                        strProductName = "Consumer Product";
                        dTotal = dQun * dPrice;
                        dDiscount = dTotal * 0.30;
                        dGross = dTotal - dDiscount;
                        goto ProductPrint;
                    }
                    else
                    {
                        goto CustomerId;
                    }
                    break;

                default:
                    goto Readme;
            }
        }
        else
        {
            goto BankDetails;
        }

    ProductPrint:
        Console.WriteLine("customer id is{0}, \n The product id is {1}, \n product name is{2}, \n total bill is{3}, \n gross price to be paid is {4}", dCustId, ipId, strProductName, dTotal, dGross);
        Console.WriteLine("\n Thankyou for shopping with us.......");
        Console.ReadLine();
    }

}