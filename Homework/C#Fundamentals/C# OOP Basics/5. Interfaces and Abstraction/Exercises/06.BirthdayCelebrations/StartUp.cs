using System;
using System.Collections.Generic;

namespace _06.BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBirthday> allBirthdays = new List<IBirthday>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "Citizen")
                {
                    IBirthday citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    allBirthdays.Add(citizen);
                }
                else if(tokens[0] == "Pet")
                {
                    IBirthday pet = new Pet(tokens[1], tokens[2]);
                    allBirthdays.Add(pet);
                }
            }

            string yearToCheck = Console.ReadLine();

            foreach (var birthday in allBirthdays)
            {
                if (birthday.Birthdate.EndsWith(yearToCheck))
                {
                    Console.WriteLine(birthday.Birthdate);
                }
            }
        }
    }
}
