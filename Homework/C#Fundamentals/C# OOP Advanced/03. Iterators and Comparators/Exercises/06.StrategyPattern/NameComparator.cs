﻿using System;
using System.Collections.Generic;
using System.Text;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);
        if (result == 0)
        {
            string xName = x.Name.ToLower();
            string yName = y.Name.ToLower();

            result = xName[0].CompareTo(yName[0]);
        }

        return result;
    }
}

