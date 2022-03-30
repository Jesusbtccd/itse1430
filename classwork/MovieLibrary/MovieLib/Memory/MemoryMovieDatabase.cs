using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Memory
{
    class MemoryMovieDatabase
    {
        public virtual void Add ( Movie movie )
        {
        }

        public void Delete ( Movie movie )
        { }
       
        public Movie Get ()
        {
            return null;
        }

        public Movie[] GetAll()
        {
            return new Movie[0];
        }

        public void Update ( Movie movie )
        { }


        private readonly List<Movie> _movies = new List<Movie>();

     

    }
}
