using System;

public class task3
{
    public int id;
    public string name;
    public int age;
    public void insert(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine("this is the id " + id + " this is the name " + name + " this is the age " + age);
    }
    public static void Main(string[] args)
    {
        int id, age;
        string name;
        
        task3 task = new task3();
        id = int.Parse(Console.ReadLine());
        name = Console.ReadLine();
        age = int.Parse(Console.ReadLine());
        task.insert(id, name, age);
        task.display();
    }
}