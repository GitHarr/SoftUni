using System;
using System.Collections.Generic;

public class Sorter<T>
    where T : IComparable<T>
{
    public static List<T> Sort(List<T> list)
    {
        list.Sort();
        return list;
    }
}

