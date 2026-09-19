using CinemaManagment.Data;
using CinemaManagment.Repository.Concrete;
using CinemaManagment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.UnitOfWorks
{
    public class UnitOfWork : IDisposable
    {
        private readonly CinemaDBContext _context;

        public UnitOfWork(CinemaDBContext context)
        {
            _context = context;
            Movies = new MovieRepository(context);
            Tickets = new TicketRepository(context);
        }

        public IMovieRepository Movies { get; }
        public ITicketRepository Tickets { get; }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
