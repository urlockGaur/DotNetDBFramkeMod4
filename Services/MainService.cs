using System;

namespace FramkeMod4MovieLibrary.Services;


public class MainService : IMainService
{
    string fileName = "movies.csv";
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {
        string choice;
        do
        {
            Console.WriteLine("Movie Application Menu\n");
            Console.WriteLine("Enter a choice: ");
            Console.WriteLine("1) Display All Movies");
            Console.WriteLine("2) Add Movie");
            Console.WriteLine("X) Quit");
            choice = Console.ReadLine().ToUpper(); // in case user enters x


            if (choice == "1")
            {
                _fileService.Read(fileName);
            }
            else if (choice == "2")
            {
                
                _fileService.Write(fileName);
            }
        }
        while (choice != "X");
    }
}
