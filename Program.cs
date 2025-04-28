using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonUserExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "user.json";

            if (File.Exists(filePath))
            {
                string jsonResponse = File.ReadAllText(filePath);

                List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);

                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.Name}");
                    Console.WriteLine($"Age: {user.Age}");
                    Console.WriteLine($"City: {user.City}");
                    Console.WriteLine(new string('-', 20));
                }
            }
            else
            {
                Console.WriteLine("JSON file not found.");
            }
        }
    }
}
