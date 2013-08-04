//Lecture 2: Primitive Data Types And Variables
//Problem 8: Declare two string variables and assign them with following value:
            //"The "use" of quotations causes difficulties."
            //Do the above in two different ways: with and without using quoted strings.


using System;

class Escaping
{
    static void Main()
    {
        string quoted = @"The ""use"" of quotations causes difficulties.";
        string escaped = "The \"use\" of quotations causes difficulties.";
        
        Console.WriteLine("Method 1  - using the @ symbol:\n{0}\n",quoted);
        Console.WriteLine("Method 2 - using the \\ for escaping:\n{0}\n",escaped);

    }
}

