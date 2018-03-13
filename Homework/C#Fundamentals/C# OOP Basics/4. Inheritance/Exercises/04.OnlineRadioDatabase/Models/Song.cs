using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName, string duration)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Duration = duration;
    }

    public string ArtistName
    {
        get => artistName;
        private set
        {
            if (value == null || value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get => songName;
        private set
        {
            if (value == null || value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            songName = value;
        }
    }

    public int Minutes
    {
        get => minutes;
        private set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException();
            }
            minutes = value;
        }
    }

    public int Seconds
    {
        get => seconds;
        private set
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException();
            }
            seconds = value;
        }
    }

    private string Duration
    {
        set
        {
            string[] timeParams = value.Split(':');
            int minutes;
            int seconds;
            try
            {
                minutes = int.Parse(timeParams[0]);
                seconds = int.Parse(timeParams[1]);
            }
            catch (FormatException)
            {
                throw new InvalidSongLengthException();
            }

            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}

