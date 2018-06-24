﻿namespace P02.KingsGambit.Models
{
    using System;
    using Interfaces;
    using IO.Interfaces;

    public class King : IPerson
    {
        private IWriter writer;

        public King(string name, IWriter writer)
        {
            this.Name = name;
            this.writer = writer;
        }

        public string Name { get; }

        public event EventHandler BeingAttacked;

        public void OnUnderAttack()
        {
            this.writer.WriteLine($"King {this.Name} is under attack!");
            if (this.BeingAttacked != null)
            {
                this.BeingAttacked(this, EventArgs.Empty);
            }
        }
    }
}
