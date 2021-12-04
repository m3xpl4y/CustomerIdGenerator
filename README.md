# CustomerId Generator
Generate a Customer Id with 2 Letters and 6 Numbers, also you can change the length of the numbers by adding the length in the constructor
How to:

            Generator gen = new Generator(context);
            Console.WriteLine(gen.NewCuid());
            
            //The standard length is 2 letters and 6 numbers
            OUTPUT:
            DX746583
            
            Generator gen2 = new Generator(9,context);
            Console.WriteLine(gen2.NewCuid());
            
            //By adding number 9 in the constructor will generate 2 letters and 9 numbers
            OUTPUT:
            AB123456789
            
context is a list of CustomerIDs which you have to retrieve from the Database. To compare with the Generated one, to avoid duplication.
