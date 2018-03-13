using System;
using System.Collections.Generic;
using System.Text;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        ParseCorps(corps);
    }

    private void ParseCorps(string corps)
    {
        bool ValidCorps = Enum.TryParse(typeof(Corps), corps, out object outCorps);

        if (!ValidCorps)
        {
            throw new ArgumentException("Invalid corps!");
        }
        this.Corps = (Corps)outCorps;
    }

    public Corps Corps { get; private set; }
}

