﻿using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    protected Food(int pointsOfHappiness)
    {
        this.PointsOfHappiness = pointsOfHappiness;
    }

    public int PointsOfHappiness { get; set; }
}