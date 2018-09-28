using System;
using System.IO;

namespace FileHandlingArticleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("arj.txt"))
            {
                string content = File.ReadAllText("important.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("arj.txt", newContent);
        }
    }
}	

