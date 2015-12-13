using System;
using System.Collections.Generic;
using System.Text;

namespace LineProcessorInCyberDojo
{
    //03DA6D 
    public class LineProcesser
    {
        internal static string Wrapper(string input, int columnNum)
        {
            var words = CollectWords(input);
            return FormatOutput(columnNum, words);
        }

        private static string FormatOutput(int columnNum, List<string> words)
        {
            var result = new StringBuilder();
            var newLine = new StringBuilder();

            foreach (var word in words)
            {
                if (newLine.Length + word.Length <= columnNum || !Char.IsLetterOrDigit(word[0]))
                {
                    newLine.Append(word);
                }
                else
                {
                    result.Append(newLine.ToString() + "\r\n");
                    newLine = new StringBuilder();
                    newLine.Append(word);
                }
            }
            result.Append(newLine.ToString());

            return result.ToString();
        }

        private static List<string> CollectWords(string input)
        {
            if (input.Equals(string.Empty)) return new List<string>() {input};

            var words = new List<string>();
            var word = input[0].ToString();
            for (var i = 1; i < input.Length; i++)
            {
                var letter = input[i];
                if (char.IsLetterOrDigit(letter))
                {
                    word = word.Insert(word.Length, letter.ToString());
                }
                else
                {
                    words.Add(word);
                    words.Add(letter.ToString());
                    word = "";
                }
            }
            if (Char.IsLetterOrDigit(input[input.Length - 1]))
            {
                words.Add(word);
            }
            return words;
        }
    }
}