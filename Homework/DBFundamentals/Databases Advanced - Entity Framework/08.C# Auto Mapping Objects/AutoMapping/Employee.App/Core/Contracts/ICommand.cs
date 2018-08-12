using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.App.Core.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
