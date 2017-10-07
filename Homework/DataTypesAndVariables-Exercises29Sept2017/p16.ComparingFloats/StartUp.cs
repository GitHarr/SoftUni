namespace p16.ComparingFloats
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            bool isEqual = true;
            double result = 0.0;

            if (num1 > num2)
            {
                result = num1 - num2;
                if (result > precision)
                {
                    isEqual = false;
                }
            }
            else
            {
                result = num2 - num1;
                if (result > precision)
                {
                    isEqual = false;
                }
            }
            Console.WriteLine(isEqual);
        }
    }
}
