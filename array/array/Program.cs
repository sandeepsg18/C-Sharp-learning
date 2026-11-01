using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        ////array(a collection of elements of the same data type stored in a single vaiable)


        //int[] numbers = { 10, 20, 30, 40, 50 };
        ////for(int i=0; i<numbers.Length;i++ )
        ////{
        ////    Console.WriteLine(numbers[i]);
        ////}
        //foreach(var i in numbers)
        //{
        //    Console.WriteLine(i);


        //}

        ////int[] arr=new int[6];

        ////Two Dimensional array

        //int[,] num = { { 1, 2, 3 }, { 7, 8, 9 } };
        //{
        //    Console.WriteLine(num[0, 2]);
        //}

        int[] marks = { 48, 45, 62, 75, 88, 99 };
        //Length
        //{
        //    Console.WriteLine(marks.Length);

        //}

        //array.sort

        //Array.Sort(marks);

        //reverse

        //Array.Reverse(marks);

        //array.index()

        //var res = Array.IndexOf(marks, 48);
        //{
        //    Console.WriteLine(res);
        //}


        //foreach (var i in marks)
        //{
        //    Console.WriteLine(i);

        //}

        //array.copy()

        //int[] newmarks = new int[5];

        //Array.Copy(marks,newmarks,5);
        //foreach(var i in newmarks)
        //{
        //    Console.WriteLine(i);
        //}

        //array.clear

        Array.Clear(marks, 2, 10);
        foreach (var i in marks)
        {

            Console.WriteLine(i);
        }









    }
}
