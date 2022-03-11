using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLib.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void onFileExit ( object sender, EventArgs e )
        {
            //confirmation exit
            DialogResult dr = MessageBox.Show(this,"Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr==DialogResult.Yes)
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

        private void onMovieAdd ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.ShowDialog(this);
        }
    }
}
