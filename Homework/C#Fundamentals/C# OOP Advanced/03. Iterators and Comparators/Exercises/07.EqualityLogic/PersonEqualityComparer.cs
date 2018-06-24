using System;
using System.Collections.Generic;
using System.Text;

public class PersonEqualityComparer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y)
    {
        bool isEqual = false;
        if (x.Name.Equals(y.Name))
        {
            if (x.Age.Equals(y.Age))
            {
                isEqual = true;
            }
        }
        return isEqual;
    }

    public int GetHashCode(Person obj)
    {
        return base.GetHashCode();
    }
}

