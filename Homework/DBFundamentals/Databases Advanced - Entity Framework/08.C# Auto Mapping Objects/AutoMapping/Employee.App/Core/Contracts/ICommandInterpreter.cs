using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.App.Core.Contracts
{
    public interface ICommandInterpreter
    {
        string Read(string[] input);
    }
}
