using System;
using System.Globalization;

namespace _05.DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            
            DateModifierClass days = new DateModifierClass();

            int diff = days.GetDaysDifference(firstInput, secondInput);
           
            Console.WriteLine(diff);
        }
    }
}
