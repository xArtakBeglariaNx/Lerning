using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_step_111_ASync_MyEBookReader
{
    class Program
    {
        private static string theBook = "";

        static void Main(string[] args)
        {
            GetBook();
            Console.WriteLine("Downloading book");
            Console.ReadLine();
        }

        static void GetBook()
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += (sender, eArgs) =>
            {
                theBook = eArgs.Result;
                Console.WriteLine("Download complete");
                GetStats();
            };
            // The Project Gutenberg EBook of A Tale of Two Cities, by Charles Dickens
            // You might have to run it twice if you’ve never visited the site before, since the first
            // time you visit there is a message box that pops up, and breaks this code.
            //Uri is changed:
            wc.DownloadStringAsync(new Uri("https://www.gutenberg.org/files/7869/7869-readme.txt"));
        }

        static void GetStats()
        {
            string[] words = theBook.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);

            string[] tenMostCommon = null;

            string longestWord = string.Empty;

            Parallel.Invoke(
                () =>
                {
                    tenMostCommon = FindTenMostCommon(words);
                },
                () =>
                {
                    longestWord = FindLongestWord(words);
                }
                );

            StringBuilder bookStats = new StringBuilder("The Most Common Words are: \n");
            foreach (string s in tenMostCommon)
            {
                bookStats.AppendLine(s);
            }

            bookStats.AppendFormat($"Longest Word is: {longestWord}");
            bookStats.AppendLine();
            Console.WriteLine(bookStats.ToString(), "Book Info");
        }

        private static string[] FindTenMostCommon(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;
            string[] commonWords = (frequencyOrder.Take(10).ToArray());
            return commonWords;
        }

        private static string FindLongestWord(string[] words)
        {
            return (from word in words orderby word.Length select word).FirstOrDefault();
        }
    }
}
