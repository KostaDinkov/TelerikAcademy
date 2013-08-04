/*
 * Lecture 5 : Conditional Statements
 * Problem 11: *    Write a program that converts a number in 
 *                  the range [0...999] to a text corresponding to its  
 *                  English pronunciation. Examples:
 *	                0  "Zero"
 *	                273  "Two hundred seventy three"
 *	                400  "Four hundred"
 *	                501  "Five hundred and one"
 *	                711  "Seven hundred and eleven"
 */

//Note: not the most elegant solution, but the program is running acording
//to the specification. I may consider polishing and redesigning it if there is time. 

using System;
using System.Collections.Generic;

class NumberSpeller
{
    static void Main()
    {   
        string number = "";
        int num =-1;
        do
        {
            Console.Write("Enter a number between 0 - 999:");
            number = Console.ReadLine();
            bool verify = int.TryParse(number, out num);
        }
        while (num < 0 || num > 999 );

        string result = string.Join(" ",SpellNum(number));
        Console.WriteLine(result);
    }
    
    
    static List<string> SpellNum(string number)
    {
        List<string> result = new List<string>();
        if (number.Length < 2 && number[0] == '0')
        {
            result.Add("zero");
            return result;
        }
        for (int i = 0; i < number.Length; i++)
        {
            if (i != (number.Length-2))
            {
                switch (number[i])
                {
                    case '1':
                        result.Add("one");
                        break;
                    case '2':
                        result.Add("two");
                        break;
                    case '3':
                        result.Add("three");
                        break;
                    case '4':
                        result.Add("four");
                        break;
                    case '5':
                        result.Add("five");
                        break;
                    case '6':
                        result.Add("six");
                        break;
                    case '7':
                        result.Add("seven");
                        break;
                    case '8':
                        result.Add("eight");
                        break;
                    case '9':
                        result.Add("nine");
                        break;
                    default:
                        break;
                }
                addPlace((number.Length - i),result);
            }
            else
            {
                
                switch (number[i])
                {

                    case '1':
                        if (number.Length > 2)
                        {
                            result.Add("and");
                        }
                        
                        switch (number[i+1])
                        {
                            case '0':
                                result.Add("ten");
                                break;
                            case '1':
                                result.Add("eleven");
                                break;
                            case '2':
                                result.Add("twelve");
                                break;
                            case '3':
                                result.Add("thirteen");
                                break;
                            case '4':
                                result.Add("fourteen");
                                break;
                            case '5':
                                result.Add("fifteen");
                                break;
                            case '6':
                                result.Add("sixteen");
                                break;
                            case '7':
                                result.Add("seventeen");
                                break;
                            case '8':
                                result.Add("eighteen");
                                break;
                            case '9':
                                result.Add("nineteen");
                                break;
                        }
                        return result;
                    case '2':
                        result.Add("twenty");
                        break;
                    case '3':
                        result.Add("thirty");
                        break;
                    case '4':
                        result.Add("fourty");
                        break;
                    case '5':
                        result.Add("fifty");
                        break;
                    case '6':
                        result.Add("sixty");
                        break;
                    case '7':
                        result.Add("seventy");
                        break;
                    case '8':
                        result.Add("eightty");
                        break;
                    case '9':
                        result.Add("ninety");
                        break;
                    default:
                        result.Add("and");
                        break;
                    
                }
            }
        
        }

        return result;
    }
    static List<string> addPlace(Int32 input,List<string> list)
    {
        switch (input)
        {
            case 3:
                list.Add("hundred");
                break;
            /*TODO: not yet implemented
            case 4:
                list.Add("thousand");
                break;
            case 7:
                list.Add("million");
                break;
             */
            default:
                break;
        }
        return list;
    }
}   

