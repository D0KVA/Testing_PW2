using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TDD.FindAnything
{
    public class FindingAnythingWord
    {
        public string FindShortestWord(string input)
        {
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.OrderBy(word => word.Length).FirstOrDefault();
        }

        public int CountWords(string input)
        {
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountCharacters(string input)
        {
            return input.Length;
        }

        public string FindNthCharacter(string input)
        {
            return Convert.ToString(input[10]);
        }

        public int CountDigits(string input)
        {
            return input.Count(char.IsDigit);
        }

        public int CountMaxConsecutiveDigits(string input)
        {
            int maxCount = 0, currentCount = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }

        public int CountOccurrences(string input, string substring)
        {
            return (input.Length - input.Replace(substring, "").Length) / substring.Length;
        }
    }
}