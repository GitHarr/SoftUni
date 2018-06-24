namespace P04.WorkForce.Models
{
    using Interfaces;

    public class PartTimeEmployee : IEmployee
    {
        private const int PartTimeEmployeeWeekHours = 20;

        public PartTimeEmployee(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public int WorkHoursPerWeek => PartTimeEmployeeWeekHours;
    }
}
