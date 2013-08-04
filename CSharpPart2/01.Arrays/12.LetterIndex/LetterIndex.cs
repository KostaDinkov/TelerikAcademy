/*
 * Telerik Academy  - Homework Solutions
 * Course    : C# Part II
 * Lecture  1: Arrays
 * Problem 12: Write a program that creates an array 
 *              containing all letters from the alphabet (A-Z). 
 *              Read a word from the console and print the index 
 *              of each of its letters in the array.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class LetterIndex
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();
        string inputUpper = input.ToUpper();
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        Dictionary<char,int> alphabet = new Dictionary<char,int>();
        int index = 1; // the index of the alphabet letters starting from 1 
        // fill the dictionary with the letters from the alpha aray and the coresponding index
        foreach (var item in alpha)
        {
            alphabet.Add(item, index);
            index++;
        }
        //print the corresponding index for each of the letters in the input word
        foreach (var letter in inputUpper)
        {
            if (alphabet.Keys.Contains(letter))
            {
                Console.WriteLine("The index of the letter {0} is {1}",letter,alphabet[letter]);
            }
        }
    }
}

