using System;

public class HelloWorld
{
    static public void Main ()
    {
        Rumus us = new Rumus();
        Console.WriteLine(us.persegi(4));
        Console.WriteLine(us.persegi(9, 5));

    }
    class Rumus
    {
       public int persegi(int a){
           return a * a;
       }
       public int persegi(int p, int l){
           return p + l;
       }
    }

}
