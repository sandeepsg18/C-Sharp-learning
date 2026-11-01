using System;
class Program
{
    public static void Main()
    {
        //ex 1
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //if(a>=b&&a>=c)
        //{
        //    Console.WriteLine(a);
        //}
        //else if(b>=a&&b>=c)
        //{
        //    Console.WriteLine(b);
        //}
        //else
        //{
        //    Console.WriteLine(c);
        //}
        //ex 2
        //int mark = Convert.ToInt32(Console.ReadLine());
        //if(mark>=90&&mark<=100)
        //{
        //    Console.WriteLine("A");
        //}
        //else if (mark >= 80)
        //{
        //    Console.WriteLine("B");

        //}
        //else if(mark>=70)
        //{
        //    Console.WriteLine("C");
        //}
        //else if (mark >= 50)
        //{
        //    Console.WriteLine("D");

        //}
        //else
        //{
        //    Console.WriteLine("Fail");
        //}
        //ex 3

        //int year = Convert.ToInt32(Console.ReadLine());
        //if(year % 400==0||(year % 4==0 && year %100!=0))
        //{
        //    Console.WriteLine("Leap year");
        //}
        //else
        //{
        //    Console.WriteLine("Not Leap year");
        //}
        //ex 4
        //char ch = Convert.ToChar(Console.ReadLine());
        //if(ch=='a'|| ch=='e' || ch=='i' || ch=='o'|| ch=='u')
        //{
        //    Console.WriteLine("Vowels");
        //}
        //else
        //{
        //    Console.WriteLine("Consonants");
        //}


        //ex 5

        //string username = Console.ReadLine();
        //string password = Console.ReadLine();

        //if (username == "admin" && password == "1234")
        //{
        //    Console.WriteLine("Login Success");

        //}
        //else
        //{
        //    Console.WriteLine("Invalid Login");
        //}

        //ex 6

        //int units = Convert.ToInt32(Console.ReadLine());
        //int bill;
        //if(units<=100)
        //{
        //    bill = units * 5;

        //}
        //else if(units<=200)
        //{
        //    bill = (100 * 5) + ((units - 100) * 7);
        //}
        //else
        //{
        //    bill = (100 * 5) + (100 * 7) + ((units - 200) * 10);
        //}
        //Console.WriteLine(bill);

        //ex 7

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if(a+b>c && b+c>a && a + c > b)
        {
            Console.WriteLine("Valid Triangle");
        }
        else
        {
            Console.WriteLine("Invalid Triangle");
        }

    }
}
