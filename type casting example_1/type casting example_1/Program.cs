using System;
class Program
{
    public static void Main()
    {
        //Console.Write("Enter your First Number:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter your Second Number:");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Final output : {a += b}");
        string username = "sandeep";
        string password = "san123";

        Console.Write("Enter your Username:");
        string user_name =Convert.ToString( Console.ReadLine());
        Console.Write("Enter your Password:");
        string password_ = Convert.ToString(Console.ReadLine());
        if(username==user_name && password == password_)
        {
            Console.WriteLine("Login Successfully");
        }
        else
                {
            Console.WriteLine("Invalid Username or Password");
        }

    }
}
