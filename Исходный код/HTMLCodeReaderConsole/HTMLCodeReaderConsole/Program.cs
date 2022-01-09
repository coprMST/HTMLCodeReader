using System;
using System.IO;

namespace VolgaIT_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Статистика";
                using (StreamReader sr = new StreamReader("result.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.ReadKey();
            }
            catch { }
        }
    }
}
