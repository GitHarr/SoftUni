using System;

namespace _02.VehiclesExtension
{
    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            double carCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            double truckCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busConsumption = double.Parse(busInfo[2]);
            double busCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carConsumption, carCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumption, truckCapacity);
            Vehicle bus = new Bus(busFuelQuantity, busConsumption, busCapacity);

            int commandsNum = int.Parse(Console.ReadLine());

            ParseCommand(car, truck, bus, commandsNum);

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ParseCommand(Vehicle car, Vehicle truck, Vehicle bus, int commandsNum)
        {
            for (int i = 0; i < commandsNum; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Drive")
                {
                    ExecuteDriveCommand(car, truck, bus, command);
                }

                else if (command[0] == "Refuel")
                {
                    try
                    {
                        ExecuteRefuelCommand(car, truck, bus, command);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else
                {
                    double distance = double.Parse(command[2]);
                    Console.WriteLine(bus.Drive(distance, command[0]));
                }
            }
        }

        private static void ExecuteRefuelCommand(Vehicle car, Vehicle truck, Vehicle bus, string[] command)
        {
            double liters = double.Parse(command[2]);

            if (command[1] == "Car")
            {
                car.Refuel(liters);
            }

            else if (command[1] == "Truck")
            {
                truck.Refuel(liters);
            }
            else
            {
                bus.Refuel(liters);
            }
        }

        private static void ExecuteDriveCommand(Vehicle car, Vehicle truck, Vehicle bus, string[] command)
        {
            double distance = double.Parse(command[2]);

            if (command[1] == "Car")
            {
                Console.WriteLine(car.Drive(distance));
            }

            else if (command[1] == "Truck")
            {
                Console.WriteLine(truck.Drive(distance));
            }
            else
            {
                Console.WriteLine(bus.Drive(distance, command[0]));
            }
        }
    }
}
