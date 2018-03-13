﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> members;

    public List<Person> Members
    {
        get { return members; }
        set { members = value; }
    }

    public Family()
    {
        Members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        Members.Add(member);
    }

    public Person GetOldestMember()
    {
        return Members.OrderByDescending(m => m.Age).FirstOrDefault();
    }
}

