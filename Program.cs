using System;
using addMultiplyDLL;

namespace JenkinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.WriteLine("adding a new line");

            addMultiply ob1 = new addMultiply();

            Console.WriteLine(ob1.add(115, 300));
            Console.WriteLine(ob1.Multiply(20, 13));
            //chvhjknk
            Console.ReadLine();
        }
    }
}
