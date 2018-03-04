namespace p01.AnonymousDownsite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class StartUp
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            BigInteger securityToken = 0;
            decimal totalLoss = 0.0M;

            for (int i = 0; i < n; i++)
            {
                var websitesData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var siteName = websitesData[0];
                long siteVisits = long.Parse(websitesData[1]);
                decimal sitePricePerVisit = decimal.Parse(websitesData[2]);

                decimal siteLoss = 0.0M;


                Console.WriteLine(siteName);

                foreach (var s in websitesData)
                {
                    siteLoss = siteVisits * sitePricePerVisit;
                }
                totalLoss += siteLoss;

                securityToken = BigInteger.Pow(securityKey, n);
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
