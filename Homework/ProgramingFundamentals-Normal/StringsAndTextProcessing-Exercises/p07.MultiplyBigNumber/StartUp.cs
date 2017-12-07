namespace p07.MultiplyBigNumber
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            char[] digit = Console.ReadLine().TrimStart('0').ToCharArray();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int residue = 0;
            string endDigit = string.Empty;

            var answerBuilder = new StringBuilder();

            for (int i = digit.Length - 1; i >= 0; i--)
            {
                int currentMulti = int.Parse(digit[i].ToString());
                int multiDone = (currentMulti * multiplier) + residue;
                char[] splitResult = multiDone.ToString().ToCharArray();

                if (splitResult.Length == 2)
                {
                    residue = int.Parse(splitResult[0].ToString());
                    endDigit = splitResult[1].ToString();
                }
                else
                {
                    residue = 0;
                    endDigit = splitResult[0].ToString();
                }

                answerBuilder.Append(endDigit);
                if (i == 0 && residue != 0)
                {
                    answerBuilder.Append(residue.ToString());
                }
            }

            var solution = answerBuilder.ToString().ToCharArray();

            Array.Reverse(solution);

            Console.WriteLine(solution);
        }
    }
}
