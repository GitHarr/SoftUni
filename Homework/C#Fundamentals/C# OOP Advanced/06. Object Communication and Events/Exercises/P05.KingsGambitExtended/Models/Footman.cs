namespace P05.KingsGambitExtended.Models
{
    using System;
    using Interfaces;
    using IO.Interfaces;

    public class Footman : Soldier
    {
        private const int FootmanHits = 2;

        public Footman(string name, IWriter writer)
            : base(name, writer)
        {
            this.Hit = FootmanHits;
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            this.Writer.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
