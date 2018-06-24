using System;

public class StartUp
{
    public static void Main()
    {
        string[] inputLine1 = Console.ReadLine().Split();
        string personName = inputLine1[0] + " " + inputLine1[1];
        string address = inputLine1[2];
        Tuple<string, string> tuple1 = new Tuple<string, string>(personName, address);

        string[] inputLine2 = Console.ReadLine().Split();
        string name = inputLine2[0];
        int litersOfBeer = int.Parse(inputLine2[1]);

        Tuple<string, int> tuple2 = new Tuple<string, int>(name, litersOfBeer);

        string[] inputLine3 = Console.ReadLine().Split();
        int myInt = int.Parse(inputLine3[0]);
        double myDouble = double.Parse(inputLine3[1]);

        Tuple<int, double> tuple3 = new Tuple<int, double>(myInt, myDouble);

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}

