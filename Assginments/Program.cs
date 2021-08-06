using System;

namespace Assginments
{
    class Program
    {

        static void Main(string[] args)
        {
         string text, word;
         int choice;
         string[] stopWordsArrary = {

                "a", "about", "actually", "after", "also", "am", "an",
                "and", "any", "are", "as", "at", "be", "because", "but",
                "by", "could", "do", "each", "either", "en", "for", "from",
                "has", "have", "how","i", "if", "in", "is", "it", "its",
                "just", "of", "or", "so", "some", "such", "that","the", "their",
                "these", "thing", "this", "to", "too", "very", "was", "we",
                "well", "what", "when", "where","who", "will", "with", "you", "your",
                "@","#","$","%","&","*"
            };
            Console.Write("Type 1: For Word Frequency Problem.\nType 2: For Calculate Date of Birth." +
                        "\nType 3: For Remove Words From Text.\nType 4: For Json to List" +
                        "\nEnter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the Text: ");
                    text = Console.ReadLine();
                    Console.Write("\n");
                    Console.Write("Enter the Word to Find the Frequency in a given Text: ");
                    word = Console.ReadLine();

                    foreach (string item in stopWordsArrary)
                    {
                        if (item == word)
                        {
                            Console.WriteLine("Not applicable");
                            return;
                        }
                    }
                    Console.Write("\n");
                    Console.WriteLine($"No. of Repetitions of '{word}' word in a given sentence: { WordFrequency.CountWordRepetition(text, word)}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Enter Year:");
                    int yyyy = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Month:");
                    int mm = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Day:");
                    int dd = Convert.ToInt32(Console.ReadLine());
                    int[] userDob = CalculateDateOfBirth.UserDateOfBirth(new DateTime(yyyy, mm, dd));
                    Console.WriteLine($"Years: {userDob[0]}, Months:{userDob[1]}, Days:{userDob[2]} ");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Enter text.");
                    string inputText = Console.ReadLine();
                    string[] resultArray = StopWordRemove.RemoveStopWord(inputText);
                    Console.WriteLine(String.Join(' ', resultArray));

                    break;
                case 4:
                    JsonToList.GetJsonFile("C:\\Datagrokr\\csharp\\Assginments\\Assginments\\Share\\data.json");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
           
        }
       
    }
}
