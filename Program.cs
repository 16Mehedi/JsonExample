using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    static void Main(string[] args)
    {
        string filePath = "user.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("JSON file not found.");
            return;
        }

        string jsonResponse = File.ReadAllText(filePath);

        // Deserialize to List<User>
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonResponse);

        // Loop through users and display info
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"City: {user.City}");
            Console.WriteLine(new string('-', 20));
        }
    }
}
