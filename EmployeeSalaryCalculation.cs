using System;

    class EmployeeSalaryCalculation
    {
    static void Main()
        {
        string strEmpName;
        double dBasic;
        Console.WriteLine("Enter the Employee salary: ");
        dBasic = int.Parse(Console.ReadLine());

    ReadAgain:
        Console.WriteLine("Enter the Employee name:");
        strEmpName = Console.ReadLine();


        switch (strEmpName)
        {
            case "jay":
                goto EmployeeSalary;
                break;

            case "Rohit":
                goto EmployeeSalary;
                break;
                break;
            case "vineeth":
                goto EmployeeSalary;

            default:
                goto ReadAgain;


        }
    EmployeeSalary:
        double dHra, dTa, dDa, dPf, dTax, dGrossSalary,dNetSalary;
        if (dBasic <= 20000)
        {
            dHra = dBasic * 0.23;
            dTa = dBasic * 0.20;
            dDa = dBasic * 0.15;
        }
        else
        {
            dHra = dBasic * 0.35;
            dTa = dBasic * 0.25;
            dDa = dBasic * 0.20;
        }
        if (dBasic <= 20000)
        {
            dPf = dBasic * 0.10;
            dTax = dBasic * 0.5;
        }
        else
        {
            dPf = dBasic * 0.15;
            dTax = dBasic * 0.10;
        }
        dGrossSalary = dBasic + dHra + dTa + dDa;
        dNetSalary = (dGrossSalary) - (dPf + dTa);
        Console.WriteLine("the net salary of employee: {0} is {1}", strEmpName, dGrossSalary);
        Console.WriteLine("Allowances Hra:{0}, Ta:{1}, Da:{2}", dHra, dTa, dDa);
        }
    }
