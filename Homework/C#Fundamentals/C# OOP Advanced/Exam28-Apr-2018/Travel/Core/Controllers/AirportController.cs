namespace Travel.Core.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    using Entities;
    using Entities.Contracts;
    using Entities.Factories;
    using Entities.Factories.Contracts;
    using Travel.Entities.Airplanes;
    using Travel.Entities.Airplanes.Contracts;
    using Travel.Entities.Items;
    using Travel.Entities.Items.Contracts;

    public class AirportController : IAirportController
    {
        private const int BagValueConfiscationThreshold = 3000;

        private IAirport airport;

        private IAirplaneFactory airplaneFactory = null;
        private IItemFactory itemFactory;

        public AirportController(IAirport airport)
        {
            this.airport = airport;
            this.airplaneFactory = new AirplaneFactory();
            this.itemFactory = new ItemFactory();
        }

        public string RegisterPassenger(string username)
        {
            //if (this.airport.GetPassenger(username) != null)
            //{
            //    throw new InvalidOperationException($"Passenger {username} already registered!");
            //}

            if (this.airport.Passengers.Any(p => p.Username == username))
            {
                throw new InvalidOperationException($"Passenger {username} already registered!");
            }

            var passenger = new Passenger(username);

            this.airport.AddPassenger(passenger);

            return $"Registered {passenger.Username}";
        }

        public string RegisterBag(string username, IEnumerable<string> bagItems)
        {
            List<IItem> items = new List<IItem>();

            var passenger = this.airport.GetPassenger(username);

            foreach (var itemName in bagItems)
            {
                IItem item = this.itemFactory.CreateItem(itemName);
                items.Add(item);
            }

            var bag = new Bag(passenger, items);

            passenger.Bags.Add(bag);

            return $"Registered bag with {string.Join(", ", bagItems)} for {username}";
        }

        public string RegisterTrip(string source, string destination, string planeType)
        {
            var airplane = this.airplaneFactory.CreateAirplane(planeType);

            var trip = new Trip(source, destination, airplane);

            this.airport.AddTrip(trip);

            return $"Registered trip {trip.Id}";
        }

        public string CheckIn(string username, string tripId, IEnumerable<int> bagsToCheckInCount)
        {
            var passenger = this.airport.GetPassenger(username);

            ITrip trip = this.airport.GetTrip(tripId);

            var passengerCheckedIn = this.airport.Trips
                .Any(p => p.Airplane.Passengers.Any(i => i.Username == username));

            if (passengerCheckedIn)
            {
                throw new InvalidOperationException($"{username} is already checked in!");
            }

            var confiscatedBags = CheckInBags(passenger, bagsToCheckInCount);

            trip.Airplane.AddPassenger(passenger);

            return
                $"Checked in {passenger.Username} with" +
                $" {bagsToCheckInCount.Count() - confiscatedBags}/{bagsToCheckInCount.Count()} checked in bags";
        }

        private int CheckInBags(IPassenger passenger, IEnumerable<int> bagsToCheckIn)
        {
            var bags = passenger.Bags;

            var confiscatedBagCount = 0;

            foreach (var i in bagsToCheckIn)
            {
                var currentBag = bags[i];
                bags.RemoveAt(i);

                if (ShouldConfiscate(currentBag))
                {
                    this.airport.AddConfiscatedBag(currentBag);
                    confiscatedBagCount++;
                }
                else
                {
                    this.airport.AddCheckedBag(currentBag);
                }
            }

            return confiscatedBagCount;
        }

        private static bool ShouldConfiscate(IBag bag)
        {
            var luggageValue = bag.Items.Sum(i => i.Value);

            var shouldConfiscate = luggageValue > BagValueConfiscationThreshold;
            return shouldConfiscate;
        }
    }
}