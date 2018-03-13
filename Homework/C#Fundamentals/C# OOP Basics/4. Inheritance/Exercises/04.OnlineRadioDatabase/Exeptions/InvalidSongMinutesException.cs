﻿using System;
using System.Collections.Generic;
using System.Text;

public class InvalidSongMinutesException : InvalidSongLengthException
{
    private const string DefaultMessage = "Song minutes should be between 0 and 14.";

    public InvalidSongMinutesException() : base(DefaultMessage) { }
}
