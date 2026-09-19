using CinemaManagment.Data;
using CinemaManagment.Entities;
using CinemaManagment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Repository.Concrete
{
    public class TicketRepository : ITicketRepository
    {
        private readonly CinemaDBContext _context;

        public TicketRepository(CinemaDBContext context)
        {
            _context = context;
        }

        public void Add(Ticket entity)
        {
            _context.Tickets.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Ticket entity)
        {
            _context.Tickets.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Ticket> GetAll()
        {
            return _context.Tickets;
        }

        public Ticket? GetByID(int id)
        {
            return _context.Tickets.SingleOrDefault(t => t.Id == id);
        }

        public void Update(Ticket entity)
        {
            _context.Tickets.Update(entity);
            _context.SaveChanges();
        }
    }
}
