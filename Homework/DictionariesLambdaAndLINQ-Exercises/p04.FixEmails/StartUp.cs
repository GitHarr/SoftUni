namespace p04.FixEmails
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string subEmail = email.Substring(email.Length - 2);
                if (subEmail != "us" && subEmail != "uk")
                {
                    emails.Add(name, email);
                }
                else
                {
                    name = Console.ReadLine();
                }
                name = Console.ReadLine();
            }
            foreach (KeyValuePair<string, string> kvp in emails)
            {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
