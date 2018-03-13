using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongLengthException : InvalidSongException
{
    private const string DefaultMessage = "Invalid song length.";

    public InvalidSongLengthException() : base(DefaultMessage) { }

    public InvalidSongLengthException(string message) : base(message) { }
}

