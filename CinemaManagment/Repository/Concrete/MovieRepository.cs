using CinemaManagment.Data;
using CinemaManagment.Entities;
using CinemaManagment.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagment.Repository.Concrete
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaDBContext _context;

        public MovieRepository(CinemaDBContext context)
        {
            _context = context;
        }

        public void Add(Movie entity)
        {
            _context.Movies.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Movie entity)
        {
            _context.Movies.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies;
        }

        public Movie? GetByID(int id)
        {
            return _context.Movies.SingleOrDefault(m => m.Id == id);
        }

        public void Update(Movie entity)
        {
            _context.Movies.Update(entity);
            _context.SaveChanges();
        }
    }
}
