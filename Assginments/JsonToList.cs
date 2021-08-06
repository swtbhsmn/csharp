using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Assginments
{
    class JsonToList
    {
        public class Employees
        {
            public string  name { get; set; }
            public int age{ get; set; }
            public string place { get; set; }
 
        }

        public static string GetJsonFile(string jsonFileLocation)
        {
            
            string jsonFilePath = $"{jsonFileLocation}";



            if (File.Exists(jsonFilePath))
            {
                Console.WriteLine("File found.");
                string json = File.ReadAllText(jsonFilePath);
                var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                Console.WriteLine("Name:"+values["name"]);
                Console.WriteLine("Age:"+values["age"]);
                Console.WriteLine("Place:"+values["city"]);


            }
            else
            {
                Console.WriteLine("File not found.");
            }
            

            return "hello";


        }
    }
}
