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
        public string lead1;
        public string lead2;
        public string lead3;

        public Movies(string title, string category1, string category2, double year, string lead1, string lead2, string lead3)
        {
            this.title = title;
            this.category1 = category1;
            this.category2 = category2;
            this.year = year;
            this.lead1 = lead1;
            this.lead2 = lead2;
            this.lead3 = lead3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] genres = new string[] { "Action", "Adventure", "Animation", "Comedy", "Drama", "Horror", "Sci-Fi" };

            List <Movies> AllMovies = new List<Movies>();
            AllMovies.Add(new Movies("It", "Horror", "Drama", 2017, "Finn Wolfhard", "", ""));
            AllMovies.Add(new Movies("The Goonies", "Adventure", "Comedy", 1985, "Sean Astin", "Corey Feldman", ""));
            AllMovies.Add(new Movies("The Dark Knight", "Action", "Drama", 2008, "Christian Bale", "Heath Ledger", "Morgan Freeman"));
            AllMovies.Add(new Movies("The Truman Show", "Comedy", "Drama", 1998, "Jim Carrey", "", ""));
            AllMovies.Add(new Movies("Downsizing", "Comedy", "Drama", 2017, "Matt Damon", "", ""));
            AllMovies.Add(new Movies("Guardians of the Galaxy", "Sci-Fi", "Action", 2014, "Chris Pratt", "Zoe Saldana", "Bradley Cooper"));
            AllMovies.Add(new Movies("Back to the Future", "Sci-Fi", "Drama", 1985, "Michael J. Fox", "Christopher Lloyd", ""));
            AllMovies.Add(new Movies("Brightburn", "Sci-Fi", "Horror", 2019, "Jackson Dunn", "", ""));
            AllMovies.Add(new Movies("Up", "Animation", "Adventure", 2009, "Ed Asner", "", ""));
            AllMovies.Add(new Movies("Ready Player One", "Sci-Fi", "Adventure", 2018, "Tye Sheridan", "Olivia Cooke", ""));
            AllMovies.Add(new Movies("Resident Evil: Degeneration", "Animation", "Horror", 2008, "Paul Mercier", "Alyson Court", ""));
            AllMovies = AllMovies.OrderBy(o=>o.title).ToList();
            AllMovies = AllMovies.OrderBy(o=>o.year).ToList();
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
                        Console.WriteLine($"{item.title} - {item.year} - {item.category1}/{item.category2} - Starring: {item.lead1} - {item.lead2} - {item.lead3}");
                    }
                }
                Console.WriteLine("\nWould you like to choose another genre? Y/N");
                string response2 = Console.ReadLine().ToLower();
                if (response2 == "n")
                {
                    keepgoing = false;
                }
                Console.Clear();
            }
            while (keepgoing);
        }
    }
}