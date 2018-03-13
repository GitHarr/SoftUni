using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const string DefaultMessage = "Song seconds should be between 0 and 59.";

    public InvalidSongSecondsException() : base(DefaultMessage)
    {
    }

    public InvalidSongSecondsException(string message) : base(message)
    {
    }
}

