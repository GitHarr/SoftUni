﻿namespace P02.KingsGambit.IO
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
