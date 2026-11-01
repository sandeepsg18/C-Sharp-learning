using System;
class Program
{
    public static void Main()
    {
        //if else()
        //ternary operator()
        //nested if()
        //elif()
        //switch()


        //if else
        //long acc_no = 1053249877;
        //int pin_no = 1234;
        //Console.Write("Enter Your Account Number:");
        //long account_no = Convert.ToInt64(Console.ReadLine());
        //Console.Write("Enter your 4 digit pin:");
        //int pin_number = Convert.ToInt32(Console.ReadLine());

        //if(acc_no==account_no && pin_no==pin_number)
        //{
        //    Console.WriteLine("Withdraw Successfully");
        //}
        //else
        //{
        //    Console.WriteLine("Account number or Pin is Invalid");
        //}

        //Ternary operator



        //var data = (AC_No == account_no && pin == Pin) ? "Valid Credentials" : "Invalid";



        //Console.WriteLine(data);



        //Nested if:



        //int age = 23;

        //bool voter_id = false;



        //if(age>=18)

        //{

        //  if(voter_id)

        //    {

        //        Console.WriteLine("Eligible for Vote");

        //    }

        //    else

        //    {

        //        Console.WriteLine("Voter_id Need");

        //    }

        //}

        //else

        //{

        //    Console.WriteLine("Not Eligible");

        //}





        //Ex_1:



        int Prelims = 150;

        int Mains = 160;

        bool Interview_pass = false;



        if (Prelims >= 148)

        {

            if (Mains >= 150)

            {

                if (Interview_pass)

                {

                    Console.WriteLine("Congratulations");

                }

                else

                {

                    Console.WriteLine("Waiting for overall Cutoff");

                }



            }

            else

            {

                Console.WriteLine("Better luck next Time, Mains mark is below Cutoff" + Mains);

            }

        }

        else

        {

            Console.WriteLine("Better Luck Next Time ,Your Mark is Low of Cutoff" + Prelims);

        }
        //else if
        //int current_year = 2026;
        //int sandeep = 2028;
        //int sathya = 2027;
        //int safwaan = 2026;
        //int suriya = 2025;
        //if(suriya < current_year )
        //{
        //    Console.WriteLine("Passedout");

        //}
        //else if(suriya>current_year)
        //    {
        //    Console.WriteLine("Will passedout");
        //}
        //else
        //{
        //    Console.WriteLine("Passedout This Year");
        //}
        //example 1
        int experience = -10;
        if (experience == 0)
        {
            Console.WriteLine("Fresher");
        }
        else if (experience == 1)
        {
            Console.WriteLine("Junior Developer");
        }
        else if (experience == 2)
        {
            Console.WriteLine("Software Developer");
        }
        else if (experience >= 3 && experience <= 5)
        {
            Console.WriteLine("Senior Developer");

        }
        else if (experience > 5)
        {
            Console.WriteLine("Team leader");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        //Switch:

        string my_name = "sathya";

        switch (my_name)
        {
            case "Tejal":
                Console.WriteLine("Hyderabad");
                break;

            case "Sandeep":
                Console.WriteLine("Namakkal");
                break;

            case "Devendra":
                Console.WriteLine("Kurnool");
                break;

            default:
                Console.WriteLine("This name is not in the list");
                break;
        }



    }
}
