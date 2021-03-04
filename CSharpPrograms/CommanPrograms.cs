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
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
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
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    status = false;
                    break;
                }
                else
                {
                    status = true;
                }
            }

            if (status)
                Console.WriteLine(str + " is Palindrome");
            else
                Console.WriteLine(str + " is not Palindrome");
        }

        public void ReverseWordsOfString(string str)
        {
            string[] splitedWords = str.Split(' ');
            for (int i = splitedWords.Length - 1; i >= 0; i--)
            {
                Console.Write(splitedWords[i] + " ");
            }
        }

        public void CountCharactersInString(string str)
        {
            Dictionary<char, int> charAndCount = new Dictionary<char, int>();
            char[] charArray = str.ToCharArray();
            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    if (!charAndCount.ContainsKey(charArray[i]))
            //    {
            //        charAndCount.Add(charArray[i], 1);
            //    }
            //    else
            //    {
            //        charAndCount[charArray[i]]++;
            //    }
            //}

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!charAndCount.ContainsKey(character))
                    {
                        charAndCount.Add(character, 1);
                    }
                    else
                    {
                        charAndCount[character]++;
                    }
                }

            }

            foreach (var character in charAndCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        public void Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is : " + fact);
        }

        public void Anagram(string word1, string word2)
        {
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newWord1 = new string(char1);
            string newWord2 = new string(char2);

            if (newWord1 == newWord2)
            {
                Console.WriteLine("Word {0} and {1} are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("Word {0} and {1} are not Anagrams", word1, word2);
            }
        }

        public void SwapWithoutUsingTemp(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        public void FibonacciSeries(int num)
        {
            int val1 = 0, val2 = 1, val3;
            for (int i = 2; i < num; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }

        public void RemoveDuplicates(string str)
        {
            string result = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if(!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
