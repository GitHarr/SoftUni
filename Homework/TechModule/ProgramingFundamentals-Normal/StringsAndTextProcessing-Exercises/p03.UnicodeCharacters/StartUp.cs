namespace p03.UnicodeCharacters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            char[] word = Console.ReadLine().ToCharArray();

            StringBuilder solution = new StringBuilder();
            foreach (char c in word)
            {
                solution.AppendFormat($"\\u{(int)c:x4}");
            }

            Console.WriteLine(solution);

            //string input = Console.ReadLine();

            //char[] toChars = input.ToCharArray();

            //StringBuilder sb = new StringBuilder();
            //foreach (char ch in toChars)
            //{
            //    //sb.Append("\\u");
            //    //sb.Append(String.Format($"{(int)ch:x4}"));
            //   sb.Append("\\u" + ((int)ch).ToString("x4"));
            //}

            //Console.WriteLine(sb.ToString());
        }
    }
}
