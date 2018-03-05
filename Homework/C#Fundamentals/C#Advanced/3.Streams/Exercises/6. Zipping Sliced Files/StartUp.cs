using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;

namespace _6._Zipping_Sliced_Files
{
    public class StartUp
    {

        private const int bufferSize = 4096;

        public static void Main()
        {
            string sourceFile = @"../sliceMe.mp4";
            string destination = "";
            int parts = 5;

            Zip(sourceFile, destination, parts);

            var files = new List<string>
            {
                "Part-0.mp4.gz",
                "Part-1.mp4.gz",
                "Part-2.mp4.gz",
                "Part-3.mp4.gz",
                "Part-4.mp4.gz",
            };

            Assemble(files, destination, sourceFile);
        }

        static void Zip(string sourceFile, string destinationDirectory, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

                long pieceSize = (long)Math.Ceiling((double)reader.Length / parts);


                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    if (destinationDirectory == string.Empty)
                    {
                        destinationDirectory = "./";
                    }

                    string currentPath = destinationDirectory + $"Part-{i}.{extension}.gz";

                    using (GZipStream writer = new GZipStream
                        (new FileStream(currentPath, FileMode.Create), CompressionLevel.Optimal))
                    {
                        byte[] buffer = new byte[bufferSize];

                        while (reader.Read(buffer, 0, bufferSize) == bufferSize)
                        {
                            writer.Write(buffer, 0, bufferSize);
                            currentPieceSize += bufferSize;

                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }


        static void Assemble(List<string> files, string destinationDirectory, string sourceFile)
        {
            string extension = sourceFile.Substring(sourceFile.LastIndexOf('.') + 1);

            if (destinationDirectory == string.Empty)
            {
                destinationDirectory = "./";
            }

            if (!destinationDirectory.EndsWith("/"))
            {
                destinationDirectory += "/";
            }

            string currentPath = $"{destinationDirectory}Assembled.{extension}";

            var source = new FileStream(currentPath, FileMode.Create);

            source.Close();

            using (source = new FileStream(currentPath, FileMode.Append))
            {

                foreach (var file in files)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    {
                        using (GZipStream compressionStream = new GZipStream
                            (reader, CompressionMode.Decompress, false))
                        {
                            byte[] buffer = new byte[bufferSize];

                            while (true)
                            {
                                int readBytes = compressionStream.Read(buffer, 0, bufferSize);

                                if (readBytes == 0)
                                {
                                 break;   
                                }

                                source.Write(buffer, 0, readBytes);
                            } 
                        }
                    }
                }
            }
        }
    }
}
