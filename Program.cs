using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Practice_July_6th_2024
    {
        static void Main(string[] args)
        {
            /*Task 1*/
            string a = "Hey fellow warriors";
            Console.WriteLine(SpinWords(a));

            /*Task 2*/
            string b = "moOse";
            Console.WriteLine($"{b} - {IsIsogram(b)}");

            /*Task 3*/
            Console.WriteLine(SumNoDuplicates(new int[] { 1, 10, 3, 10, 10 }));
            Console.ReadKey();


        }


        /*  Task 1
         * 
         * Write a function that takes in a string of one or more words, 
         * and returns the same string, but with all words that have five 
         * or more letters reversed (Just like the name of this Kata).
         * Strings passed in will consist of only letters and spaces. 
         * Spaces will be included only when more than one word is present.
 
        "Hey fellow warriors"  --> "Hey wollef sroirraw" 
        "This is a test        --> "This is a test" 
        "This is another test" --> "This is rehtona test"
         */
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string newStr = "";
            foreach (string word in words)
            {
                if (word.Length >= 5)
                {
                    newStr += new string(word.Reverse().ToArray());
                }
                else newStr += word;
                newStr += " ";

            }
            return newStr.Trim();
        }

        /* public static string Spin_Words(string sentence)
        {
        return string.Join(" ", sentence.Split(' ')
                                        .Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));
         }*/



        /*  Task 2
         * 
         * An isogram is a word that has no repeating letters, 
         * consecutive or non-consecutive. Implement a function 
         * that determines whether a string that contains only
         * letters is an isogram. Assume the empty string is an
         * isogram. Ignore letter case.
         
         
        "Dermatoglyphics" --> true
        "aba" --> false
        "moOse" --> false (ignore letter case)
         */

        public static bool IsIsogram(string str)
        {
            if (str == null) return true;
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            List<char> newChars = new List<char>();
            foreach (char c in chars)
            {
                if (!newChars.Contains(c))
                {
                    newChars.Add(c);
                }
                else return false;
            }
            return true;
        }

        /* Task 3
         * 
         * Please write a function that sums a list, but ignores any duplicated items in the list.

        For instance, for the list [3, 4, 3, 6] the function should return 10,
        and for the list [1, 10, 3, 10, 10] the function should return 4.*/

        public static int SumNoDuplicates(int[] arr)
        {
            int sum = 0;
            return arr.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).Sum(s => sum + s);
        }
    }
}
