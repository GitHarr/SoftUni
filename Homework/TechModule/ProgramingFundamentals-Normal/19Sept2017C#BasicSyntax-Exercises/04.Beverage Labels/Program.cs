using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyByVolume = (energy * volume) / 100.0;
            double sugarByVolume = (sugar * volume) / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyByVolume}kcal, {sugarByVolume}g sugars");
        }
    }
}
