using CinemaManagment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.DapperReport
{
    public class MovieDapper
    {
        public MovieDapper()
        {
            Tickets = new List<TicketDapper>();
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set; }
        public ICollection<TicketDapper>? Tickets { get; set; }
    }
}
