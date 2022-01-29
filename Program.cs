using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string userChoice = GetUserChoice();

            while (userChoice.ToUpper() != "X")
            {
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        AddSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DestroySerie();
                        break;
                    case "5":
                        ViewSerie();
                        break;
                    default:
                        Console.WriteLine("Please select a valid option...");
                        break;
                }

                userChoice = GetUserChoice();
            }
        }

		private static void ListSeries()
		{
            Console.WriteLine("Series List: ");

            var seriesList = repository.List();

            if (seriesList.Count == 0)
            {
               Console.WriteLine("No series in our list yet...") ;
               return;
            }

            foreach (var serie in seriesList)
            {
                var destroyed = serie.returnDestroyed();

                Console.WriteLine(
                    $"#ID {serie.returnId()}: - {serie.returnTitle()} {(destroyed ? "*Deleted*" : "")}"
                );
            }
		}

		private static void DestroySerie()
        {
            Console.Write("Enter serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());

            repository.Destroy(serieIndex);
        }

        private static void ViewSerie()
        {
            Console.Write("Enter serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());

            var serie = repository.ReturnById(serieIndex);

            Console.WriteLine(serie);
        }

        private static void AddSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Select a genre: ");
            int inputGenre = int.Parse(Console.ReadLine());
            
            Console.Write("Serie's Title: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Series's launch year: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Serie's Description: ");
            string inputDescription = Console.ReadLine();

            Serie newSerie = new Serie(
                id: repository.NextId(),
                genre: (Genre)inputGenre,
                title: inputTitle,
                year: inputYear,
                description: inputDescription
            );

            repository.Add(newSerie);
        }
        private static void UpdateSerie()
        {
            Console.Write("Enter serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Select a genre: ");
            int inputGenre = int.Parse(Console.ReadLine());
            
            Console.Write("Serie's Title: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Series's launch year: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Serie's Description: ");
            string inputDescription = Console.ReadLine();

            Serie updatedSerie = new Serie(
                id: serieIndex,
                genre: (Genre)inputGenre,
                title: inputTitle,
                year: inputYear,
                description: inputDescription
            );

            repository.Update(serieIndex, updatedSerie);
        }
        private static string GetUserChoice()
        {
            Console.Write(@"
            ##############################
            Welcome to DIO Series!
            1 - Show all series
            2 - Add new serie
            3 - Update serie info
            4 - Delete serie
            5 - View serie
            X - Quit
            ##############################
            Please select a option: ");

            string userChoice = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userChoice;
        }
    }
}
