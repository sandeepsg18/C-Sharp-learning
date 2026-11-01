using System;
using System.Collections.Generic;
using System.Text;

namespace variables
{
    internal class employee
    {

        public string employee_name;
        public string dept_name;
        public static string company_name = "zoho";

        public void employee_details()
        {
            Console.WriteLine(employee_name);
            Console.WriteLine(dept_name);
            Console.WriteLine(company_name);
        }


    }
}