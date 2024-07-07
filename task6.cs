using System;
using System.Text;

public class task6
{
    public void concat_string(string str)
    {
        string st = " vp .NET lab";
        str = string.Concat(str, st);
        Console.WriteLine("Inside concat_string: " + str); // To show the result of concatenation inside the method
    }

    public void concat_string_builder(StringBuilder str)
    {
        str.Append(" vp .NET Lab");
    }

    public static void Main(string[] args)
    {
        task6 task = new task6();

        string str1 = "Welcome";
        task.concat_string(str1);
        Console.WriteLine("Outside concat_string: " + str1); // The original string will remain unchanged

        StringBuilder str2 = new StringBuilder("Welcome");
        task.concat_string_builder(str2);
        Console.WriteLine(str2.ToString());
    }
}
