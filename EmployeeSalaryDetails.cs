using System;


namespace jaggu
{
    class Employee
    {
        public void Show()
        {
            Console.WriteLine("This is Show method");
        }
    }
    class SalaryEmployee : Employee
    {
        public void Display()
        {
            Console.WriteLine("This is display method and calling show method");
            Show();
        }
    }
    class Salary
    {
        public static void Main(string[] args)
        {
            Employee em = new Employee();
            em.Show();
            SalaryEmployee se = new SalaryEmployee();
            se.Display();
            Console.ReadKey();
        }
    }

}
