/*
 * Lecture 3 : Operators And Expressions
 * Problem 4 : Write an expression that checks
 *              for given integer if its third 
 *              digit (right-to-left) is 7. 
 *              E. g. 1732  true.
 */           


using System;

class CheckFor7
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());              //Assuming a valid input is provided (not going to perform input validation anymore ;))
        bool has7 = (input / 100) % 10 == 7;                    //First we do a int by int division to make the 3rd digit to become 1st.
                                                                //Then we divide the result by 10 and compare the reminder to see if its equal to 7
        
        Console.WriteLine(has7?"The number {0} contains the digit 7\nin the 3rd position from right to left":
                               "The number {0} DOES NOT contain the digit 7\nin the 3rd position from right to left",input);
    }
}
