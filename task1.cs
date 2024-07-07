using System;

class task1 {
    public static void Main(string[] args) {
        Console.WriteLine("hello,World!......");
        int n , r , temp , sum = 0;
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}