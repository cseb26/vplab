using System;

public class employee
{
    protected int salary = 40000; // Use protected for inheritance

    public int GetSalary()
    {
        return salary;
    }
}

public class Programmer : employee
{
    protected int bonus = 20000; // Use protected for inheritance

    public int GetBonus()
    {
        return bonus;
    }
}

public class man : Programmer
{
    protected bool hike = true; // Use protected for inheritance

    public bool GetHike()
    {
        return hike;
    }
}

public class task4
{
    public static void Main(string[] args)
    {
        man manInstance = new man();
        Console.WriteLine("the salary is " + manInstance.GetSalary() + " and the bonus is " + manInstance.GetBonus() + " and the hike is " + manInstance.GetHike());

        Programmer programmerInstance = new Programmer();
        Console.WriteLine("the salary is " + programmerInstance.GetSalary() + " and the bonus is " + programmerInstance.GetBonus());

        employee employeeInstance = new employee();
        Console.WriteLine("the salary is " + employeeInstance.GetSalary());
    }
}
