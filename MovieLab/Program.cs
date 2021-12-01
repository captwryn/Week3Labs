using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLab
{
    class Movies
    {
        public string title;
        public string category1;
        public string category2;
        public double year;

        public Movies(string title, string category1, string category2, double year)
        {
            this.title = title;
            this.category1 = category1;
            this.category2 = category2;
            this.year = year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //animated*, drama*, horror*, scifi*, adventure*, comedy*, action*
            Movies TheGoonies = new Movies("The Goonies", "Adventure", "Comedy", 1985);
            Movies TheDarkKnight = new Movies("The Dark Knight", "Action", "Drama", 2008);
            Movies It = new Movies("It", "Horror", "Drama", 2017);
            Movies Downsizing = new Movies("Downsizing", "Comedy", "Drama", 2017);
            Movies TheTrumanShow = new Movies("The Truman Show", "Comedy", "Drama", 1998);
            Movies GotG = new Movies("Guardians of the Galaxy", "Sci-Fi", "Action", 2014);
            Movies BttF = new Movies("Back to the Future", "Sci-Fi", "Drama", 1985);
            Movies Brightburn = new Movies("Brightburn", "Sci-Fi", "Horror", 2019);
            Movies Up = new Movies("Up", "Animation", "Adventure", 2009);
            Movies RP1 = new Movies("Ready Player One", "Sci-Fi", "Adventure", 2018);
            Movies RED = new Movies("Resident Evil: Degeneration", "Animation", "Horror", 2008);

            string[] genres = new string[] { "Action", "Adventure", "Animation", "Comedy", "Drama", "Horror", "Sci-Fi" };

            List <Movies> AllMovies = new List<Movies>();
            AllMovies.Add(It);
            AllMovies.Add(TheGoonies);
            AllMovies.Add(TheDarkKnight);
            AllMovies.Add(TheTrumanShow);
            AllMovies.Add(Downsizing);
            AllMovies.Add(GotG);
            AllMovies.Add(BttF);
            AllMovies.Add(Brightburn);
            AllMovies.Add(Up);
            AllMovies.Add(RP1);
            AllMovies.Add(RED);
            AllMovies = AllMovies.OrderBy(o=>o.title).ToList();
            AllMovies = AllMovies.OrderBy(o => o.year).ToList();
            bool keepgoing = true;
            do
            {
                Console.WriteLine("For a list of movies in a genre, please choose a genre:\n(1) Action (2) Adventure (3) Animation (4) Comedy (5) Drama (6) Horror (7) Sci-Fi");
                int response = int.Parse(Console.ReadLine());
                string entry = genres[response - 1];
                Console.WriteLine($"\n--{entry} Movies--");

                foreach (var item in AllMovies)
                {
                    if (item.category1.Contains(entry) || item.category2.Contains(entry))
                    {
                        Console.WriteLine($"{item.title} - {item.year} - {item.category1}/{item.category2}");
                    }
                }
                Console.WriteLine("\nWould you like to choose another genre? Y/N");
                string response2 = Console.ReadLine().ToLower();
                if (response2 == "n")
                {
                    keepgoing = false;
                }
            }
            while (keepgoing);
        }
    }
}