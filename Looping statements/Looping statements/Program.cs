using System;
class Program
{
    public static void Main()
    {
        //while loop
        //do while loop
        //for loop
        //nested for loop
        //foreach


        //while loop
        //int age = 19;

        //while(age > 15)
        //{
        //    Console.WriteLine($"My age is {age}");
        //    age--;
        //}

        //example 1

        //int age = 10;

        //while (age < 15)
        //{
        //    Console.WriteLine($"My age is {age}");
        //    age++;
        //}
        //Do while loop:
        //int age = 10;
        //do
        //{
        //    Console.WriteLine($"My age is {age}");
        //    age++;
        //}
        //while (age < 15);

        //for loop:
        //for (initialization; Condition; increment/Decrement)

        //int i;
        //for (i = 0;i<10;i++)
        //{
        //    Console.WriteLine($"i = {i}");

        //}

        //Ex 1:
        //int i;
        //for (i = 15; i > 10; i--)
        //{
        //    Console.WriteLine($"i = {i}");

        //}

        //Nested for:
        //Do while loop:
        //int age = 10;
        //do
        //{
        //    Console.WriteLine($"My age is {age}");
        //    age++;
        //}
        //while (age < 15);

        //for loop:
        //for (initialization; Condition; increment/Decrement)

        //int i;
        //for (i = 0;i<10;i++)
        //{
        //    Console.WriteLine($"i = {i}");

        //}

        //Ex 1:
        //int i;
        //for (i = 15; i > 10; i--)
        //{
        //    Console.WriteLine($"i = {i}");

        //}

        //Nested for:
        int i, j;
        for (i = 1; i < 5; i++)
        {
            for (j = 5; j < 8; j++)
            {
                Console.WriteLine($"{j}*{i}");
            }
            Console.WriteLine();
        }
    }
}