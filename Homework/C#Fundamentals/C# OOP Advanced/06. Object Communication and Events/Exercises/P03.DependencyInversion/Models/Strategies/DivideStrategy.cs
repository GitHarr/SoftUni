﻿namespace P03.DependencyInversion.Models.Strategies
{
    using Interfaces;

    public class DivideStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
