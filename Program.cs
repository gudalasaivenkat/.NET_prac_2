
using System;

// Interface
interface IPayroll
{
    double CalculateSalary();
}

// Base class
class Employee : IPayroll
{
    public int Id;
    public string Name;
    public double BasicSalary;

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        BasicSalary = salary;
    }

    // Virtual method for polymorphism
    public virtual double CalculateSalary()
    {
        return BasicSalary;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Salary: Rs. " + CalculateSalary());
    }
}

// Derived class
class Manager : Employee
{
    public double Bonus;

    public Manager(int id, string name, double salary, double bonus)
        : base(id, name, salary)
    {
        Bonus = bonus;
    }

    // Method overriding
    public override double CalculateSalary()
    {
        return BasicSalary + Bonus;
    }
}

// Derived class
class Developer : Employee
{
    public double Allowance;

    public Developer(int id, string name,
                     double salary, double allowance)
        : base(id, name, salary)
    {
        Allowance = allowance;
    }

    // Method overriding
    public override double CalculateSalary()
    {
        return BasicSalary + Allowance;
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism
        Employee e1 = new Manager(101, "Rahul", 40000, 10000);
        Employee e2 = new Developer(102, "Priya", 35000, 5000);

        Console.WriteLine("--- Employee Payroll System ---\n");

        e1.Display();
        Console.WriteLine();

        e2.Display();

        Console.ReadLine();
    }
}
