using System;
using System.Collections.Generic;
using System.Text;

public interface IMyList : IRemovable
{
    int NumberOfElements { get; }
}
