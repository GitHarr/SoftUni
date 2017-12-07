namespace p04.CharacterMultiplier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] lineOfWords = Console.ReadLine().Split();

            char[] firstWord = lineOfWords[0].ToCharArray();
            char[] secondWord = lineOfWords[1].ToCharArray();

            long sum = 0;

            if (firstWord.Length >= secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }

                for (int j = secondWord.Length; j < firstWord.Length; j++)
                {
                    sum += firstWord[j];
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                }

                for (int j = firstWord.Length; j < secondWord.Length; j++)
                {
                    sum += secondWord[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
