using System;
using System.Collections.Generic;
using System.Text;

public class PersonComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.CompareTo(y.Name);
        if (result == 0)
        {
            result = y.Age.CompareTo(x.Age);
        }
        return result;
    }
}

