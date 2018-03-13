using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private SeasonsMultiplier seasonMultiplier;
    private DiscountsEnum discount;

    public PriceCalculator(string command)
    {
        var splitCommand = command.Split();
        pricePerNight = decimal.Parse(splitCommand[0]);
        nights = int.Parse(splitCommand[1]);
        seasonMultiplier = Enum.Parse<SeasonsMultiplier>(splitCommand[2]);

        discount = DiscountsEnum.None;

        if (splitCommand.Length > 3)
        {
            discount = Enum.Parse<DiscountsEnum>(splitCommand[3]);
        }
    }
    public string CalculatePrice()
    {
        var tempTotal = pricePerNight * nights * (int) seasonMultiplier;
        var discountPercentage = ((decimal) 100 - (int) discount) / 100;
        var totalPrice = tempTotal * discountPercentage;

        return totalPrice.ToString("F2");
    }
}

