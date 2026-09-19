using CinemaManagment.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.DapperReport
{
    public class TicketDapper
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int MovieId { get; set; }
        public MovieDapper? Movie { get; set; }
    }
}
