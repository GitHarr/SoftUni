namespace p01.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var dataSetInfo = new Dictionary<string, Dictionary<string, long>>();

            List<string> dataSetList = new List<string>();

            string inputData = Console.ReadLine();

            while (inputData != "thetinggoesskrra")
            {
                string[] data = inputData.Split("->| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (data.Length == 1)
                {
                    string dataSet = data[0];
                    dataSetList.Add(dataSet);
                }

                else
                {
                    string dataKey = data[0];
                    long dataSize = long.Parse(data[1]);
                    string dataSet = data[2];

                    if (!dataSetInfo.ContainsKey(dataSet))
                    {
                        dataSetInfo.Add(dataSet, new Dictionary<string, long>());
                    }
                    dataSetInfo[dataSet][dataKey] = dataSize;
                }

                inputData = Console.ReadLine();
            }

            //dataSetInfo.ToList()
            //    .Where(e => !dataSetList.Contains(e.Key))
            //    .ToList()
            //    .ForEach(e => dataSetInfo.Remove(e.Key));      -> works with or without the filtration

            if (dataSetInfo.Count > 0)
            {
                var result = dataSetInfo.OrderByDescending(x => x.Value.Sum(e => e.Value))
                    .First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e => e.Value)}");

                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
