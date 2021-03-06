﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PetClinic
{
    public class StartUp
    {
        public static void Main()
        {
            List<Pet> pets = new List<Pet>();
            List<PetClinicClass> clinics = new List<PetClinicClass>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandInput = Console.ReadLine().Split();

                string command = commandInput[0];

                switch (command)
                {
                    case "Create":
                        try
                        {
                            string typeOfCreation = commandInput[1];
                            if (typeOfCreation == "Pet")
                            {
                                int age = int.Parse(commandInput[3]);
                                Pet pet = new Pet(commandInput[2], age, commandInput[4]);
                                pets.Add(pet);
                            }
                            else
                            {
                                int roomCount = int.Parse(commandInput[3]);
                                PetClinicClass clinic = new PetClinicClass(commandInput[2], roomCount);
                                clinics.Add(clinic);
                            }
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Add":
                        Pet petToAdd = pets.FirstOrDefault(p => p.Name == commandInput[1]);
                        PetClinicClass clinicToAdd = clinics.FirstOrDefault(c => c.Name == commandInput[2]);
                        Console.WriteLine(clinicToAdd.Add(petToAdd));
                        break;
                    case "Release":
                        PetClinicClass clinicToRelease = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                        Console.WriteLine(clinicToRelease.Release());
                        break;
                    case "HasEmptyRooms":
                        PetClinicClass clinicToCheck = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                        Console.WriteLine(clinicToCheck.HasEmptyRooms);
                        break;
                    case "Print":
                        PetClinicClass clinicToPrint = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                        if (commandInput.Length == 3)
                        {
                            int roomNumber = int.Parse(commandInput[2]);
                            Console.WriteLine(clinicToPrint.Print(roomNumber));
                        }
                        else
                        {
                            Console.WriteLine(clinicToPrint.PrintAll());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
