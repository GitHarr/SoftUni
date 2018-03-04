namespace p01.RotateArrayOfStrings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            string[] rotatedArr = new string[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                rotatedArr[i + 1] = arr[i];
            }

            var lastElement = arr[rotatedArr.Length - 1];
            rotatedArr[0] = lastElement;

            Console.WriteLine(string.Join(" ", rotatedArr));
        }
    }
}
