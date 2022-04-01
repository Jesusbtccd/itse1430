using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MovieLib
{
   public class MovieDatabase
   {
        //Constructor chaining - one constructor calls another one
        public MovieDatabase () : this("My Movies")
        {
            //do minimal initialization of instance, if any
            //dont initialize fields - use field initializers
            //unless 
            //depends on other fields
            //relies on data available after initialization

            //repicate initializtion code
            //Initialize();
            //{
            //    _id = 1;
            //}
        }

        //private void Initialize ()
        //{
        //    _id = 1;
        //}

        public MovieDatabase ( string name )
        {
            //Initialze();
            _id =1;

            Name = name;
           
        }
        //private string _name;

        private int _id;

        public string Name { get; set; }

        //virtual means derived types can override but base has default implementation
        //overide means a derived type is overriding a base type's implementation
        public virtual void Add (Movie movie)
        {
        }
        
        public void Delete (Movie movie)
        { }
        public Movie Find (string name)
        {
            return null;
        }

        public Movie Get ()
        {
            return null;
        }

        public void Update (Movie movie)
        { }

        protected void Foo () { }
        
    }

  
}
