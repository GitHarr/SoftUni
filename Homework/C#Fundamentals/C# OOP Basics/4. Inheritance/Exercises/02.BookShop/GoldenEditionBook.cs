﻿using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string author, string title, decimal price)
        : base(author, title, price)
    {
    }

    protected override decimal Price
    {
        get
        {
            return base.Price * (decimal)1.3;
        }
    }
}
