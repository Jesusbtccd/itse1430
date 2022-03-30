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

namespace Movielib.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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

        private void OnMovieAdd (object sender, EventArgs e)
        {
            var dlg = new MovieForm();

            //
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: save movie
            _movie = dlg.Movie;
            UpdateUI();
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            var menuItem = sender as ToolStripMenuItem;
            //sender == _miCharacterEdit;
            //TODO: Get selected movie
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            //TODO: Show form
            var dlg = new MovieForm();
            dlg.Movie = movie;


            //TODO: Update movie
            _movie = dlg.Movie;
            UpdateUI();
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
            _movie = null;
            UpdateUI();

        }

        private Movie GetSelectedMovie () => _lstMovies.SelectedItem as Movie;

        private void UpdateUI ()
        {
            _lstMovies.Items.Clear();
            if (_movie != null)
                _lstMovies.Items.Add(_movie);
        }

        private Movie _movie;

        
    }
}
