using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextProcessingApplication
{
    internal class TextProcessor
    {
        public event EventHandler ProcessingCompleted;

        public void ProcessText(string filepath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                Console.WriteLine(lines.Length);
                var countWords = lines.Select(line => CountWords(line)).Sum();
                Console.WriteLine(countWords);
                CalculateCharFrecuency(lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int CountWords(string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        private Dictionary<char, int> CalculateCharFrecuency(string[] text)
        {
            Dictionary<char, int> frecuency = new Dictionary<char, int>();
            // char = 'a' --> 5
            // char = 'b' --> 3
            // char = 'c' --> 2
            var noSpaces = text.Select(line => line.Replace(" ", ""));
            string allText = string.Join("", noSpaces);

            Console.WriteLine(allText);
            foreach (char c in allText)
            {
                if (frecuency.ContainsKey(c))
                {
                    frecuency[c]++;
                }
                else
                {
                    frecuency.Add(c, 1);
                }
            }
            
            foreach (var item in frecuency)
            {
                Console.WriteLine($"Char: {item.Key} --> {item.Value}");
            }
            return frecuency;
        }

        private string FindLongestWord(string text)
        {
            return null;
        }

        protected virtual void OnProcessingCompleted()
        {

        }
    }
}
