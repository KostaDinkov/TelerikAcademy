/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 1: Arrays
 * Problem 3: Write a program that compares two char 
 *              arrays lexicographically (letter by letter).
 */
using System;

class LexicographicalComparisson
{
    static void Main()
    {
        char[] firstArray = new char [8] {'h','x','g','k','z','u','b','u'};
        char[] secindArray = new char[8] {'h','e','l','l','o','y','o','u'};

        for (int index = 0; index < firstArray.Length; index++)
        {
            Console.WriteLine("{0} {1} {2}",
                firstArray[index],
                Relation(firstArray[index],secindArray[index]),
                secindArray[index]);
            
        }
        
    }
    static string Relation( char a, char b)
    {
        string result;
        if (a==b)
        {
            result = "is equal to";
        }
        else if (a<b)
        {
            result = "is lesser than";
        }
        else
        {
            result = "is greater than";
        }
        return result;
    }
}

