using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _8._Full_Directory_Traversal
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Directory pat: ");

            string directoryPath = Console.ReadLine();

            List<string> directories = GetAllDirectories(directoryPath);

            if (!directories.Any())
            {
                Console.WriteLine("No directories found.");
                Environment.Exit(0);
            }

            var files = new Dictionary<string, List<FileInfo>>();

            foreach (var directory in directories)
            {
                GetDirectoryFilesByExtension(directoryPath, files);
            }

            if (!files.Any())
            {
                Console.WriteLine("No files found");
                Environment.Exit(0);
            }

            files = files
                .OrderByDescending(f => f.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(d => d.Key, c => c.Value);

            SaveReportToFile(files);
        }

        private static List<string> GetAllDirectories(string directoryPath)
        {
            var allDirectories = new List<string>();

            var directories = Directory.GetDirectories(directoryPath);

            foreach (var directory in directories)
            {
                allDirectories.AddRange(GetAllDirectories(directory));
            }

            allDirectories.Add(directoryPath);

            return allDirectories;
        } 

        private static void GetDirectoryFilesByExtension(string directoryPath, Dictionary<string, List<FileInfo>> filesDict)
        {
            var files = Directory.GetFiles(directoryPath);

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
        }

        private static void SaveReportToFile(Dictionary<string, List<FileInfo>> files)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string fullFileName = desktop + "/report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in files)
                {
                    string extension = pair.Key;

                    writer.WriteLine(extension);

                    var fileInfos = pair.Value
                        .OrderByDescending(fi => fi.Length);

                    foreach (var fileInfo in fileInfos)
                    {
                        double fileSize = (double) fileInfo.Length / 1024;

                        writer.WriteLine($"--{fileInfo.Name} - {fileSize:f3}kb");
                    }
                }
            }
        }
    }
}
