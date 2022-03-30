using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Memory
{
    class MemoryMovieDatabase
    {
        public virtual string Add ( Movie movie )
        {
            //TODO: Validate
            if (movie == null)
                return "Movie cannot be null";
            var error = movie.Validate();
            if (!String.IsNullOrEmpty(error))
                return "Movie is invalid";

            //Title must be unique
            var existing = FindByName(movie.Title);
            if (existing != null)
                return "Movie must be unique";

            //Add
            -_movies.Add(_movie);
            return "";

        }

        private Movie FindByName ( string name )
        {
            //foreach rules
            //1.loop variant is readonly
            //2.array cannot change
            foreach (var movie in _movies)
                if (String.Equals(movie.Title, name, StringComparison.CurrentCultureIgnoreCase))
                    return movie;

            return null;
        }

        public void Delete ( Movie movie )
        { }
       
        public Movie Get ()
        {
            return null;
        }

        public Movie[] GetAll()
        {
            //TODO:broken
            return _movies.ToArray();
        }

        public void Update ( Movie movie )
        { }


        private readonly List<Movie> _movies = new List<Movie>();

     

    }
}
