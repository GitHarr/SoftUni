namespace p03.Regexmon
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
            string str = Console.ReadLine();

            string bojomonPat = @"[a-zA-Z]+-[a-zA-Z]+";
            string didimonPat = @"[^a-zA-Z\-]+";

            Regex bojomon = new Regex(bojomonPat);
            Regex didimon = new Regex(didimonPat);

            StringBuilder sb = new StringBuilder(str);

            while (sb.Length > 0)
            {
                if (didimon.IsMatch(str))
                {
                    Match match = didimon.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }

                if (bojomon.IsMatch(str))
                {
                    Match match = bojomon.Match(sb.ToString());
                    Console.WriteLine(match.Groups[0]);
                    int index = sb.ToString().IndexOf(match.Groups[0].ToString(), 0);
                    sb.Remove(0, match.Groups[0].ToString().Length + index);
                }
            }
        }

    }
}    
