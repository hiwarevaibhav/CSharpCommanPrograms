using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    class CommanPrograms
    {
        public void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length-1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedString = new string(charArray);
            Console.WriteLine("Reverse of string " + str + " is " + reversedString);
        }

        public void Palindrome(string str)
        {
            bool status = false;
            for (int i = 0, j = str.Length-1; i < str.Length/2; i++, j--)
            {
                if(str[i] != str[j])
                {
                    status = false;
                    break;
                }
                else
                {
                    status = true;
                }
            }

            if(status)
                Console.WriteLine(str + " is Palindrome");
            else
                Console.WriteLine(str + " is not Palindrome");
        }

        public void ReverseWordsOfString(string str)
        {
            string[] splitedWords = str.Split(' ');
            Array.Reverse(splitedWords);
            for (int i = 0; i <= splitedWords.Length - 1; i++)
            {
                Console.Write(splitedWords[i] + "" + ' ');
            }
            int x = 0;
        }

        public void FindCharactersAndCountInString(string str)
        {
            Dictionary<char, int> charcount = new Dictionary<char, int>();
            for (int i = 8; i < str.Length; i++)
            {

            }
            int a = 0;
        }
    }
}
