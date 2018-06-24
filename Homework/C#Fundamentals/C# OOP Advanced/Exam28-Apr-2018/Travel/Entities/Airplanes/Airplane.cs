namespace Travel.Entities.Airplanes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using Entities.Contracts;
    using Travel.Entities.Airplanes.Contracts;
    
    public abstract class Airplane : IAirplane
    {
        private readonly List<IBag> baggageCompartment;
        private readonly List<IPassenger> passengers;

        protected Airplane(int seats, int bags)
        {
            this.Seats = seats;
            this.BaggageCompartments = bags;
            this.baggageCompartment = new List<IBag>();
            this.passengers = new List<IPassenger>();
        }

        public int Seats { get; }
        public int BaggageCompartments { get; }
        public IReadOnlyCollection<IBag> BaggageCompartment => (IReadOnlyCollection<IBag>)this.baggageCompartment;
        public IReadOnlyCollection<IPassenger> Passengers => (IReadOnlyCollection<IPassenger>)this.passengers;
        public bool IsOverbooked => this.Passengers.Count > this.Seats;

        public void AddPassenger(IPassenger passenger)
        {
            this.passengers.Add(passenger);
        }

        public IPassenger RemovePassenger(int seatIndex)
        {
            this.passengers.RemoveAt(seatIndex);

            var passenger = this.passengers[seatIndex];

            return passenger;
        }

        public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)
        {
            var passengerBags = this.baggageCompartment
                .Where(b => b.Owner == passenger)
                .ToArray();

            foreach (var bag in passengerBags)
                this.baggageCompartment.Remove(bag);

            return passengerBags;
        }

        public void LoadBag(IBag bag)
        {
            var isBaggageCompartmentFull = this.BaggageCompartment.Count > this.BaggageCompartments;
            if (isBaggageCompartmentFull)
                throw new InvalidOperationException($"No more bag room in {this.GetType().ToString()}!");

            this.baggageCompartment.Add(bag);
        }
    }
}