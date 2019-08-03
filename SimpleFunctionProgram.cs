using System;

class SimpleFunctionProgram

{
    public int id;
    public string name;
    public float salary;
    public void Employee(int i, string n, float s)
    {
        id = i;
        name = n;
        salary = s;


        Console.WriteLine(id + " " + name + " " + salary);
    }
}

class Test
{ 

    public static void Main()
    {
        SimpleFunctionProgram p = new SimpleFunctionProgram();
        p.Employee(101, "jay", 21300);
        //Console.WriteLine(p.Employee);
        Console.ReadKey();
    }
}
