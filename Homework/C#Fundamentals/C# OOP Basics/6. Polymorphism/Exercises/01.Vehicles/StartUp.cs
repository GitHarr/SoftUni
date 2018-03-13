using System;

namespace _01.Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);

            Vehicle car = new Car(carFuelQuantity, carConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumption);

            int commandsNum = int.Parse(Console.ReadLine());

            ParseCommand(car, truck, commandsNum);

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ParseCommand(Vehicle car, Vehicle truck, int commandsNum)
        {
            for (int i = 0; i < commandsNum; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "Drive")
                {
                    TravelDistance(car, truck, command);
                }

                else
                {
                    RefuleTank(car, truck, command);
                }
            }
        }

        private static void TravelDistance(Vehicle car, Vehicle truck, string[] command)
        {
            double distance = double.Parse(command[2]);

            if (command[1] == "Car")
            {
                Console.WriteLine(car.Drive(distance));
            }
            else
            {
                Console.WriteLine(truck.Drive(distance));
            }
        }

        private static void RefuleTank(Vehicle car, Vehicle truck, string[] command)
        {
            double liters = double.Parse(command[2]);

            if (command[1] == "Car")
            {
                car.Refuel(liters);
            }
            else
            {
                truck.Refuel(liters);
            }
        }
    }
}
