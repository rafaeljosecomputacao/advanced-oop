using System;
using System.IO;
using System.Collections.Generic;
using UserLog.Models.Entities;

namespace UserLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> records = new HashSet<LogRecord>();

            string sourcePath = @"c:\temp\log.txt";

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        records.Add(new LogRecord(username, instant));
                    }

                    Console.WriteLine("Total users: " + records.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error occurred: " + e.Message);
            }
        }
    }
}
