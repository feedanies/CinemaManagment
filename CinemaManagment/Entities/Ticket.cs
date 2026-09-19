using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }
    }
}
