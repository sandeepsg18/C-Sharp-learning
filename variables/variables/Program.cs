using System;
using variables;

class Program
{


    public static void Main()
    {
        //Local variable - declared inside a method
        //string name = "Sandeep";
        //long phone_no = 9940831568;


        //Console.Write(name);
        //Console.WriteLine(phone_no);

        //Student obj1 = new Student();
        //obj1.student_details();

        employee obj1 = new employee();
        obj1.employee_name = "safwaan";
        obj1.dept_name = "IT";
        obj1.employee_details();

        Console.WriteLine("-----");

        employee obj2 = new employee();
        obj2.employee_name = "sathya";
        obj2.dept_name = "HR";
        obj2.employee_details();

        Console.WriteLine("-----");

        employee obj3 = new employee();
        obj3.employee_name = "yuvi";
        obj3.dept_name = "HR";
        obj3.employee_details();
    }


}