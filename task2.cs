using System;

public class task2
{
    public int add(int a)
    {
        return a + 1;
    }
    public int add(int a, int b) 
    {
        return a + b; 
    }
    public int add(int a , int b, int c)
    {
        return a + b + c;
    }
    public static void Main(string[] args)
    {
        task2 task = new task2();
        Console.WriteLine(task.add(1));
        Console.WriteLine(task.add(1, 2));
        Console.WriteLine(task.add(1, 2, 3));
    }
}