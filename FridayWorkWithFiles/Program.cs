using System;
using System.IO;

namespace FridayWorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what files would you like to move to fruit folder?");
            Console.WriteLine("Hi what files would you like to move to vegetables folder?");
            FruitDeleter();
            
            

        }
        public static void FruitFile()
        {
            string userInput = Console.ReadLine();

            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string DestinationFruit = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            

            string fileFullName = $"{userInput}.txt";
            File.Move(Path.Combine(rootPath, fileFullName), Path.Combine(DestinationFruit, userInput));

        }
        public static void VegetableFile()
        {
            string userInput = Console.ReadLine();

            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string DestinationFruit = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";


            string fileFullName = $"{userInput}.txt";
            File.Move(Path.Combine(rootPath, fileFullName), Path.Combine(DestinationFruit, userInput));
        }
        public static void FruitDeleter()
        {
            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File dosent exist");
            }

        }

      

            
            
        



    }
}
