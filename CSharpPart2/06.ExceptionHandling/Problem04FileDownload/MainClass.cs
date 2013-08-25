/*
 * Telerik Academy  - Homework Solutions
 * Course   : C# Part II
 * Lecture 7: Exception Handling
 * Problem 3: Write a program that downloads a file from Internet g
 *              (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
 *              it the current directory. Find in Google how to download files in C#. 
 *              Be sure to catch all exceptions and to free any used resources in the 
 *              finally block.
 */


using System;
using System.IO;

using System.Net;

namespace Problem04FileDownload
{
    class MainClass
    {
        static void Main()
        {
            DownloadFileFromWeb();
        }
        static void DownloadFileFromWeb()
        {
            WebClient myWebClient = new WebClient();
           
            HttpWebResponse response = null;
            
            try
            {
                Console.WriteLine("Enter the URL of the file you wish to download");
                string url = Console.ReadLine();
                if (url == "")
                {
                    throw new ArgumentOutOfRangeException();
                }
                string filename = Path.GetFileName(url);
                var request = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)request.GetResponse();
                              
                Console.WriteLine("Enter destination folder:");
                string destination = Console.ReadLine() ;
                while (!Directory.Exists(destination))
                {
                    Console.WriteLine("Invalid directory!");
                    Console.WriteLine("Enter destination folder:");
                    destination = Console.ReadLine();
                    return;
                }
                destination = destination + '\\' + filename;
                Console.WriteLine("Downloading...");
                myWebClient.DownloadFile(new Uri(url), destination);
                Console.WriteLine();
                Console.WriteLine("Download Complete");
                

            }
            catch (ArgumentOutOfRangeException aur)
            {
                Console.WriteLine("Input can't be empty");
            }
            catch (ArgumentException )
            {
                Console.WriteLine("Invalid characters in path");
            }
            catch (WebException)
            {
                Console.WriteLine("File Not Found!");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Can't determine the url format");
            }
            finally
            {
                if (response!=null)
                {
                    response.Close();
                }
            }
            
        }

        

    }
}
