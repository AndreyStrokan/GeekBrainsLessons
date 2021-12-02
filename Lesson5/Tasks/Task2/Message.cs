using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Tasks.Task2
{
    internal static class Message
    {
        public static List<string> GetWordsNoLongerThan(string text, int limitation)
        {
            List<string> result = new List<string>();

            string[] allWords = GetAllWords(text);
            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].Length <= limitation)
                {
                    result.Add(allWords[i]);
                }
            }

            return result;
        }

        public static List<string> GetWordsWhichNotEndIn(string text, char endSymbol)
        {
            List<string> result = new List<string>();

            string[] allWords = GetAllWords(text);
            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].EndsWith(endSymbol) == false)
                {
                    result.Add(allWords[i]);
                }
            }

            return result;
        }

        public static List<string> GetTheLongestWords(string text)
        {
            List<string> result = new List<string>();

            string[] allWords = GetAllWords(text);

            int maxWordLength = int.MinValue;
            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].Length > maxWordLength)
                {
                    maxWordLength = allWords[i].Length;
                }
            }

            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].Length == maxWordLength)
                {
                    result.Add(allWords[i]);
                }
            }

            return result;
        }

        public static string FormAString(List<string> words)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < words.Count; i++)
            {
                stringBuilder.Append(words[i]);
                if (i < words.Count - 1)
                {
                    stringBuilder.Append(" ");
                }
            }

            return stringBuilder.ToString();
        }

        public static void PrintWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"Word: {words[i]} | Length: {words[i].Length} ");
            }
        }

        private static string[] GetAllWords(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]) == false)
                {
                    stringBuilder.Append(text[i]);
                }
                else
                {
                    stringBuilder.Append(" ");
                }
            }

            string[] result = stringBuilder.ToString()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return result;
        }
    }
}
