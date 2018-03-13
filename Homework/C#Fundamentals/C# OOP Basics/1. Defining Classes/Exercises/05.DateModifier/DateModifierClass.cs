using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class DateModifierClass
{
    public int GetDaysDifference(string startDate, string endDate)
    {
        DateTime start = DateTime.ParseExact(startDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs(start.Subtract(end).Days);
    }
}

