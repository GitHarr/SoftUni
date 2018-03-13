using System;
using System.Collections.Generic;
using System.Text;

public class Child : Person
{
    private const int CHILD_AGE = 15;

    public Child(string name, int age)
        : base(name, age)
    {
    }

    public override int Age
    {
        get
        {
            return base.Age;
        }

        set
        {
            if (value > CHILD_AGE)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            base.Age = value;
        }
    }
}

