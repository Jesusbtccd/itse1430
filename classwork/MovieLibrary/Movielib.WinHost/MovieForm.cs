﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MovieLib;

namespace Movielib.WinHost
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            //onLoad(e)
            base.OnLoad(e);

            //Load UI
            if (Movie != null)
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtGenre.Text = Movie.Genre;
                _chkIsClassic.Checked = Movie.IsClassic;
                _ddlRating.Text = Movie.Rating;
                _txtDuration.Text = Movie.Duration.ToString();
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
            };
        }

        private int ReadAsInt32 ( Control control, int defaultValue )
        {
            
                if (Int32.TryParse(control.Text, out var result))
                    return result;

                return defaultValue;
            
        }
        private void OnSave ( object sender, EventArgs e )
        {

            //create a new movie
            var movie = new Movie();

            //Set properties from UI
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Genre = _txtGenre.Text;
            movie.IsClassic = _chkIsClassic.Checked;
            movie.Rating = _ddlRating.Text;
            movie.Duration = ReadAsInt32(_txtDuration, -1);
            movie.ReleaseYear = ReadAsInt32(_txtReleaseYear, -1);



            //validate
            var error = movie.Validate();
            if (String.IsNullOrEmpty(error))
            {
                //validate
                Movie = movie;
                DialogResult = DialogResult.OK;
                Close();
                return;
            };


            //display
            MessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
            
        }
    }
}
