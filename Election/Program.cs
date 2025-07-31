using System;
using System.IO;
using System.Collections.Generic;

namespace Election
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string sourcePath = @"c:\temp\votes.csv";

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);
                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> pair in dictionary)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value + " votes");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error occurred: " + e.Message);
            }
        }
    }
}
