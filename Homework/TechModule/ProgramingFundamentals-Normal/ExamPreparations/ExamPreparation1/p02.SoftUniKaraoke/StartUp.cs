namespace p02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            string[] players = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            string[] songs = Regex.Split(Console.ReadLine(), @"\s*,\s*");

        }
    }
}
