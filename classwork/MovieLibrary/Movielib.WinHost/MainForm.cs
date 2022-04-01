using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using MovieLib;
using MovieLib.Memory;

namespace Movielib.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);


            //if database is empty
            if (_movies.GetAll().Length == 0)
            {
                if (MessageBox.Show(this, "Do you want to seed the database?", "Seed",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //seed database
                    var seed = new SeedDatabase();
                    seed.Seed(_movies);
                    UpdateUI();
                };
            };
        }
        protected override void OnFormClosing ( FormClosingEventArgs e )
        {
            //Confirm exit
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (dr != DialogResult.Yes)
            {
              e.Cancel = true;
                //user clicked yes
                //Close();
            };
        }
    

    private void OnFileExit ( object sender, EventArgs e )
        {
            //Confirm exit
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (dr == DialogResult.Yes)
            {
                //user clicked yes
                Close();
            };

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog(this);
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();

            //Show modally - blocking call

            do
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                //TODO: save movie
                var error = _movies.Add(dlg.Movie);
                if (String.IsNullOrEmpty(error))
                {
                    dlg.Movie.Title = "Star Wars";
                    UpdateUI();
                    return;
                };

                MessageBox.Show(this, error, "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (true);
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
           
            //sender == _miCharacterEdit;
            //TODO: Get selected movie
            var movie = GetSelectedMovie();
            if (movie == null)
                return;
            var dlg = new MovieForm();
            dlg.Movie = movie;

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Update movie
           var error = _movies.Update(movie.Id, dlg.Movie);
                if (String.IsNullOrEmpty(error))
                {
                    UpdateUI();
                    return;
                };
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //TODO: Get selected movie
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            //Confirm delete
            if (MessageBox.Show(this, $"Are you sure you want to delete {movie.Title}?", "Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //TODO: Delete
            _movies.Delete(movie);
            UpdateUI();

        }

        private Movie GetSelectedMovie ()
        {
            return _lstMovies.SelectedItem as Movie;
        }

        private void UpdateUI ()
        {
            _lstMovies.Items.Clear();

            var movies = _movies.GetAll();
            BreakMovies(movies);

            _lstMovies.Items.AddRange(movies);
        }

        private void BreakMovies ( Movie[] movies )
        {
            if (movies.Length > 0)
            {
                var firstMovie = movies[0];

                //movies[0] = new movie();
                firstMovie.Title = "Star Wars";
            };
        }

        private Movie _movie;
        private readonly MemoryMovieDatabase _movies = new MemoryMovieDatabase();

    }
}
