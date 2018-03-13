using System;
using System.Collections.Generic;
using System.Text;

public interface IRemovable : IAddable
{
    void Remove();

    void GetRemovedElements();
}
