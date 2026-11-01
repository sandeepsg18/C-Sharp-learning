using System;

class Program
{
    public static void Main()
    {
        TypeCasting(Changing the Datatype from one to another)
        Implecit Casting(Automatic Conversion)(from Small to Large)
        Explecit Casting(Manual Conversion)(From Large to Small)

        Implecit Casting:(Process)

        //int -> long -> float -> double ->decimal 

        //Explecit:(Process)

        //decimal -> double -> float -> long -> int

        //Implecit:

        //int a = 15;
        //long b = a;
        //Console.WriteLine(b);

        //long c = 30;
        //float d = c;
        //Console.WriteLine(d);

        //long e = 25;
        //double f = e;
        //Console.WriteLine(f);

        //double g = 20;
        //decimal h = g;
        //Console.WriteLine(h);


        //Explecit

        //float a = 10.7f;
        int b = Convert.ToInt32(a);
        Console.WriteLine(b);

        double c = 20.54332567;
        float d = Convert.ToSingle(c);
        Console.WriteLine(d);

        float e = 30.456789f;
        long f = Convert.ToInt64(e);
        Console.WriteLine(f);

        decimal g = 26.2345678909m;
        double h = Convert.ToDouble(g);
        Console.WriteLine(h);


    }
}
