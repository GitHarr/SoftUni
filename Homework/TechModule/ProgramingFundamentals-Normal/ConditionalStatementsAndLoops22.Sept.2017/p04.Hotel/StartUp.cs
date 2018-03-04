
namespace p04.Hotel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;

            double oneNigth = 0.0;

            if (month == "may" || month == "october")
            {
                oneNigth = 50.0;
                priceStudio = nightsCount * oneNigth;
                priceDouble = nightsCount * 65.0;
                priceSuite = nightsCount * 75.0;

                if (nightsCount > 7)
                {
                    priceStudio -= 5 / 100.0 * priceStudio;
                }
            }
            else if (month == "june" || month == "september")
            {
                oneNigth = 60.0;
                priceStudio = nightsCount * oneNigth;
                priceDouble = nightsCount * 72.0;
                priceSuite = nightsCount * 82.0;

                if (nightsCount > 14)
                {
                    priceDouble -= 10 / 100.0 * priceDouble;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                priceStudio = nightsCount * 68.0;
                priceDouble = nightsCount * 77.0;
                priceSuite = nightsCount * 89.0;

                if (nightsCount > 14)
                {
                    priceSuite -= 15 / 100.0 * priceSuite;
                }
            }
            if (month == "september" || month == "october" && nightsCount > 7)
            {
                if (month == "october")
                {
                    priceStudio -= oneNigth - 5 / 100.0 * oneNigth;
                }
                else
                {
                    priceStudio -= oneNigth; 
                }
            }
           
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
    }
}
