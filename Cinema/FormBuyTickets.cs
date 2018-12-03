using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FormBuyTickets : Form
    {
        public FormBuyTickets()
        {
            InitializeComponent();
        }

       

        private void btnRegistration_Click_1(object sender, EventArgs e)
        {
            FormSignIn newForm = new FormSignIn();
            newForm.Show();
        }

        private void btnChooseFilm_Click(object sender, EventArgs e)
        {
           FormFilmAbout newForm = new FormFilmAbout();
            newForm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAboutTheCinema newForm = new FormAboutTheCinema();
            newForm.Show();
        }
    }
}
