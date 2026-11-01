using System;


class Program
{
    public static void Main()
    {
        //Data Type

        //int
        //long
        //float
        //double
        //decimal
        //bool
        //string
        //char
        //datetime
        //dateonly
        //timeonly  
        //object
        

        int number = 1000000;
        long phone = 9940831568;
        //float ku 6-9 significant digits
        float price = 10.24f;
        //double ku 15-17 significant digits
        double balance = 105.999954;
        //decimal ku 28-29 significant digits
        decimal my_salary = 17000.00m;
        bool status = false;
        string name = "sandeep";
        char grade = 'A';
        DateTime Today=DateTime.now
        DateOnly Today_date=DateOnly.FromDateTime(DateTime.Today)
        TimeOnly Time = TimeOnly.FromDateTime(DateTime.Now);


        Console.WriteLine(number);
        Console.WriteLine(phone);
        Console.WriteLine(price);
        Console.WriteLine(balance);
        Console.WriteLine(my_salary);
        Console.WriteLine(status);
        Console.WriteLine(name);
        Console.WriteLine(grade);
        Console.WriteLine(Today);
        Console.WriteLine(Today_date);
        Console.WriteLine(Time);






    }
}
