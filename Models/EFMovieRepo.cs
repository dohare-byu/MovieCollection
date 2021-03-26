using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class EFMovieRepo : IMovieRepo
    {
        private MovieContext _context;

        public EFMovieRepo(MovieContext context)
        {
            _context = context;
        }
        public MovieContext GetContext()
        {
            return _context;
        }

        public IQueryable<Movie> movies => _context.Movies;
    }
}
