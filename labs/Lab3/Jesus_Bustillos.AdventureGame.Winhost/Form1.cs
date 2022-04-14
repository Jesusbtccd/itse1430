using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesus_Bustillos.AdventureGame.Winhost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        //{
        //    this.Close();
        //}

        private void exitToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            FormAbout Form = new FormAbout();
            Form.Show();
        }
    }
}
