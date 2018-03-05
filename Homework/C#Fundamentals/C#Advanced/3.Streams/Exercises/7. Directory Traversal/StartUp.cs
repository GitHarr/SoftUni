﻿using System.Collections.Generic;
using System.IO;
using  System.Linq;

namespace _7._Directory_Traversal
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string path = Console.ReadLine();

            var filesDict = new Dictionary<string, List<FileInfo>>();

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!filesDict.ContainsKey(extension))
                {
                    filesDict[extension] = new List<FileInfo>();
                }

                filesDict[extension].Add(fileInfo);
            }

            filesDict = filesDict
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            //string desktop = @"%USERPROFILE%\Desktop\"; ---> not working correctly

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //   ----> use this to get Desktop on different PC's.

            string fullFileName = desktop + "/report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in filesDict)
                {
                    string extension = pair.Key;

                    writer.WriteLine(extension);

                    var fileInfos = pair.Value
                        .OrderByDescending(fi => fi.Length);    //---> order by size descending

                    foreach (var fileInfo in fileInfos)
                    {
                        double fileSize = (double) fileInfo.Length / 1024;  //---> from byte to kb

                        writer.WriteLine($"--{fileInfo.Name} - {fileSize:f3}kb");
                    }
                }
            }
        }
    }
}
