using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\mmcgi\OneDrive\Desktop\Programming\Pride and Prejudice by Jane Austen.txt";

            //reads entire file into one SINGLE string
            //string contentsOfFile = File.ReadAllText(filePath);

            var lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (currentLine.Contains("Chapter"))
                {
                    Console.ReadKey();
                }

                Console.WriteLine(currentLine);
            }

            //output 5 lines at a time of the file
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }

            //    Console.WriteLine(lines[i]);
            //}

            Console.WriteLine(lines);
        }
    }
}
