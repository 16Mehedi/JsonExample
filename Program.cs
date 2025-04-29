using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "user_types.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("JSON file not found.");
            return;
        }

        string jsonResponse = File.ReadAllText(filePath);

        JArray jsonArray = JArray.Parse(jsonResponse);
        List<User> users = new List<User>();

        foreach (var item in jsonArray)
        {
            string type = item["UserType"]?.ToString();

            switch (type)
            {
                case "Admin":
                    AdminUser admin = item.ToObject<AdminUser>();
                    users.Add(admin);
                    break;

                case "Regular":
                    RegularUser regular = item.ToObject<RegularUser>();
                    users.Add(regular);
                    break;
            }
        }

        // Output
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"City: {user.City}");
            Console.WriteLine($"UserType: {user.UserType}");

            if (user is AdminUser admin)
                Console.WriteLine($"AdminLevel: {admin.AdminLevel}");

            if (user is RegularUser regular)
                Console.WriteLine($"SubscriptionType: {regular.SubscriptionType}");

            Console.WriteLine(new string('-', 30));
        }
    }
}
