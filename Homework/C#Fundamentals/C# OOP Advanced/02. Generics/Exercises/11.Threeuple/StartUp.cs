using System;

public class StartUp
{
    public static void Main()
    {
        string[] inputLine1 = Console.ReadLine().Split();
        string personName = $"{inputLine1[0]} {inputLine1[1]}";
        string address = inputLine1[2];
        string town = inputLine1[3];
        Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(personName, address, town);

        string[] inputLine2 = Console.ReadLine().Split();
        string name = inputLine2[0];
        int litersOfBeer = int.Parse(inputLine2[1]);
        string drinkOrNot = inputLine2[2];

        bool isDrunkOrNot = drinkOrNot == "drunk";

        Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunkOrNot);

        string[] inputLine3 = Console.ReadLine().Split();
        string clientName = inputLine3[0];
        double accountBalance = double.Parse(inputLine3[1]);
        string bankName = inputLine3[2];

        Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(clientName, accountBalance, bankName);

        Console.WriteLine(threeuple1);
        Console.WriteLine(threeuple2);
        Console.WriteLine(threeuple3);
    }
}

