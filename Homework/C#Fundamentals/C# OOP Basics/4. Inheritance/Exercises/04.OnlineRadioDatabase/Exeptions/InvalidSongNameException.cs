using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongNameException : InvalidSongException
{
    private const string DefaultMessage = "Song name should be between 3 and 30 symbols.";

    public InvalidSongNameException() : base(DefaultMessage)
    {
    }

    public InvalidSongNameException(string message) : base(message)
    {
    }
}

