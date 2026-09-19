using CinemaManagment.DapperReport;
using CinemaManagment.Data;
using CinemaManagment.Entities;
using CinemaManagment.UnitOfWorks;

namespace CinemaManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CinemaDBContext context = new CinemaDBContext();
            UnitOfWork uf = new UnitOfWork(context);

            //Movie movie1 = new Movie()
            //{
            //    Title = "Intersteller",
            //    Genre = "Sci-fi",
            //    Year = 2015
            //};

            //uf.Movies.Add(movie1);

            //Movie movie2 = new Movie()
            //{
            //    Title = "Inception",
            //    Genre = "Sci-fi",
            //    Year = 2008
            //};

            //uf.Movies.Add(movie2);


            //Ticket ticket1 = new Ticket()
            //{
            //    Price = 15,
            //    MovieId = 1
            //};

            //uf.Tickets.Add(ticket1);

            //Ticket ticket2 = new Ticket()
            //{
            //    Price = 8,
            //    MovieId = 1
            //};

            //uf.Tickets.Add(ticket2);

            //Ticket ticket3 = new Ticket()
            //{
            //    Price = 22,
            //    MovieId = 2
            //};

            //uf.Tickets.Add(ticket3);

            /////////////////////////////////////

            Report report = new Report();
            var movies = report.GetMovieTickets();
            foreach (var m in movies)
            {
                Console.WriteLine($"Title: {m.Title}");
                Console.WriteLine($"Genre: {m.Genre}");
                Console.WriteLine($"Year: {m.Year}");
                foreach (var t in m.Tickets)
                {
                    Console.WriteLine($"Price: {t.Price}");
                }
                Console.WriteLine();
            }


        }
    }
}
