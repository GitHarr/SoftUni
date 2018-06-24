using System;
using System.Collections.Generic;
using System.Text;

namespace P05.KingsGambitExtended.Models
{
    using System;
    using Interfaces;
    using IO.Interfaces;

    public class RoyalGuard : Soldier
    {
        private const int RoyalGuardHits = 3;

        public RoyalGuard(string name, IWriter writer)
            : base(name, writer)
        {
            this.Hit = RoyalGuardHits;
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            this.Writer.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
