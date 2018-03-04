namespace p04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var namesEmails = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                namesEmails[name] = email;

                line = Console.ReadLine();
            }

            var fixedEmails = namesEmails.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var nameEmail in fixedEmails)
            {
                var name = nameEmail.Key;
                var email = nameEmail.Value;

                Console.WriteLine($"{name} -> {email}");
            }
            Console.WriteLine();
        }
    }
}
