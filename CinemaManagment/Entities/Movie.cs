using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Entities
{
    public class Movie
    {
        public Movie()
        {
            Tickets = new List<Ticket>();
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}
