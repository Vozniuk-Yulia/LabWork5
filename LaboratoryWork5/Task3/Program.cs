using System;
namespace Task3
{
    internal class Program
    {
        enum Version
        {
            WithoutKey,
            ExpertKey,
            ProKey
        }
        public static void ChooseCommand(DocumentWorker worker, string path)
        {
            while (true)
            {
                Console.WriteLine("Enter number of command, which want to do");
                Console.WriteLine("1) Open the document");
                Console.WriteLine("2) Edit the document");
                Console.WriteLine("3) Save the document");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        worker.OpenDocument(path);
                        break;
                    case 2:
                        worker.EditDocument(path);
                        break;
                    case 3:
                        worker.SaveDocument(path);
                        break;
                }
            }

        }

        static void Main(string[] args)
        {
            string path = @"../../../TextFile.txt";
            Version typeOfVersion = Version.WithoutKey;
            Console.WriteLine("Please, enter key:");
            string keyVersion = Console.ReadLine();
            if (String.IsNullOrEmpty(keyVersion) || Int32.Parse(keyVersion) == 0)
            {
                typeOfVersion = Version.WithoutKey;
            }
            else if (Int32.Parse(keyVersion) % 2 == 0)
            {
                typeOfVersion = Version.ProKey;
            }
            else if (Int32.Parse(keyVersion) % 2 != 0)
            {
                typeOfVersion = Version.ExpertKey;
            }
            DocumentWorker worker;
            switch (typeOfVersion)
            {

                case Version.ProKey:
                    Console.WriteLine("You have pro version");
                    worker = new ProDocumentWorker();
                    ChooseCommand(worker, path);
                    break;
                case Version.ExpertKey:
                    Console.WriteLine("You have expert version");
                    worker = new ExpertDocumentWorker();
                    ChooseCommand(worker, path);
                    break;
                case Version.WithoutKey:
                    Console.WriteLine("You have free version");
                    worker = new DocumentWorker();
                    ChooseCommand(worker, path);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}