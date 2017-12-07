namespace p01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal allOrders = 0.0M;

            for (int i = 0; i < ordersCount; i++)
            {
                decimal orderPricePerMonth = CalculateOrderPrice();
                Console.WriteLine($"The price for the coffee is: ${orderPricePerMonth:F2}");
                allOrders += orderPricePerMonth;
            }

            Console.WriteLine($"Total: ${allOrders:F2}");
        }

        static decimal CalculateOrderPrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string orderDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(orderDate, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

            return price;
        }
    }
}
