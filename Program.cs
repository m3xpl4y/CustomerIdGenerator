using System;
using System.Collections.Generic;

namespace CustomerIdGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> context = new List<string>() { "DX645789", "AC125489", "KL985632" }; //replace this list with a Database!

            //Generate a CustomerId of 2 Letters and 6 numbers
            //context replaces a list retrived from the Database
            //to compare with already assigned CustomerIds in the Database
            //to not assigned the same one twice

            Generator gen = new Generator(context);
            Console.WriteLine(gen.NewCuid());
            Console.WriteLine(gen.NewCuid());
            
            //Choose the length your CustomerId by adding first a number for length
            
            Generator gen2 = new Generator(9,context);
            Console.WriteLine(gen2.NewCuid());
            Console.WriteLine(gen2.NewCuid());
        }
    }
}
