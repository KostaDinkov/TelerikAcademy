/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 8: Strings and Text processing
 * Problem 7: Write a program that encodes and decodes a string 
 *              using given encryption key (cipher). The key 
 *              consists of a sequence of characters. The encoding/decoding 
 *              is done by performing XOR (exclusive or) operation over the 
 *              first letter of the string with the first of the key, the second – 
 *              with the second, etc. When the last key character is reached, 
 *              the next is the first.
 */

//NOTE: I have done 2 versions of the Encode/Decode method.
//The first one reads input text from a file and writes the result to another file
//The second returns a string and takes an input string and the key
//There is also a helper function EncodeChar which does the actual XOR encoding over the unicode numbers of the symbols.

using System;
using System.Text;
using System.IO;

namespace Problem07EncodeDecode
{
    class MainClass
    {
        static void Main()
        {
            string inputPath = @"..\..\01.original.txt";
            string encodedPath = @"..\..\02.encoded.txt"; 
            string decodePath = @"..\..\03.decoded.txt";
            string key = "1214";
            
            //encoding from a txt file to a txt file
            EncDec(inputPath, encodedPath, key);
            
            //decoding from the encoded file to new file for decoded version, ...
            //...so that we keep the original unchanged for testing usage
            EncDec(encodedPath, decodePath, key);

            //uncoment the following lines to see the EncDec method working with a simple string

            //string encodedText = EncDec("Just a string", "key");
            //Console.WriteLine("Encoded text: {0}",encodedText);
            //string decodedText = EncDec(encodedText, "key");
            //Console.WriteLine("Decoded text : {0}",decodedText);


        }

        private static void EncDec(string inputPath, string outPath, string key)
        {
            string line;
            using (StreamReader reader = new StreamReader(inputPath))
            {
                using (StreamWriter writer = new StreamWriter(outPath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.Write(EncDec(line, key));
                    }
                }
            }
        }
        static string EncDec(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            
            int keyIndex = 0;
            
            foreach (var letter in input)
            {
                if (keyIndex==key.Length)
                {
                    keyIndex = 0;
                }
                result.Append(EncodeChar(letter, key[keyIndex]));
            }
            return result.ToString();
        }
        static char EncodeChar(char input, char key)
        {
            return (char)((int)input ^ (int)key);
        }
    }

}
