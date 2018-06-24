namespace P05.KingsGambitExtended.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriteLine : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
