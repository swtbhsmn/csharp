using System;

namespace Assginments
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text, word;
            string[] stopWordsArrary = {

                "a", "about", "actually", "after", "also", "am", "an",
                "and", "any", "are", "as", "at", "be", "because", "but",
                "by", "could", "do", "each", "either", "en", "for", "from",
                "has", "have", "how","i", "if", "in", "is", "it", "its",
                "just", "of", "or", "so", "some", "such", "that","the", "their",
                "these", "thing", "this", "to", "too", "very", "was", "we",
                "well", "what", "when", "where","who", "will", "with", "you", "your"

            };

            Console.Write("Enter the Text: ");
            text = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Enter the Word to Find the Frequency in a given Text: ");
            word = Console.ReadLine();

            foreach(string item in stopWordsArrary)
            {
                if (item == word)
                {
                    Console.WriteLine("Not applicable");
                    return;
                }
            }
            Console.Write("\n");
            Console.WriteLine($"No. of Repetitions of '{word}' word in a given sentence: { CountWordRepetition(text, word)}");
            Console.ReadKey();
        }
        private static int CountWordRepetition(string sentence, string word)
        {
            int count = 0;
            int i = 0;
           

            while ((i = sentence.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            return count;
        }
    }
}
