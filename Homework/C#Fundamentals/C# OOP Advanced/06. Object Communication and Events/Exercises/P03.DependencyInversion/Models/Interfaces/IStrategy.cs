namespace P03.DependencyInversion.Models.Interfaces
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
