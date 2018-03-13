using System;

namespace _04.OnlineRadioDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            SongDatabase database = new SongDatabase();

            for (int i = 0; i < inputCount; i++)
            {
                string[] songParams = Console.ReadLine().Split(';');
                string artistName = songParams[0];
                string songName = songParams[1];
                string duration = songParams[2];

                try
                {
                    Song song = new Song(artistName, songName, duration);
                    database.AddSong(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(database);
        }
    }
}
