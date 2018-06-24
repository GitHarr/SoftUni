namespace P03.DependencyInversion.IO
{
    using System;
    using Interfaces;

    public class ConsoleReadLine : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
