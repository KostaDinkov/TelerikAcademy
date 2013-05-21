//Lecture 2: Primitive Data Types And Variables
//Problem 7: Declare two string variables and assign them with “Hello” and “World”. 
            //Declare an object variable and assign it with the concatenation of the first two 
            //variables (mind adding an interval). Declare a third string variable and initialize 
            //it with the value of the object variable (you should perform type casting).


using System;

class HelloWorld
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concat = hello + " " + world;
        string result = (string)concat;
        Console.WriteLine(result);
    }
}
