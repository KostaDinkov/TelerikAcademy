/* Lecture  2: Primitive Data Types And Variables
 * Problem 13: Create a program that assigns null values to an integer and 
 *             to double variables. Try to print them on the console, 
 *             try to add some values or the null literal to them and 
 *             see the result.
 */ 
using System;

class NullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
        
        int numberA = 1;
        double numberB = 1.123;
        
        nullInt += numberA;
        nullDouble += numberB;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = numberA;
        nullDouble = numberB;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

    }
}

