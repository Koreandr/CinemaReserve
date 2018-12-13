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
        FormSignIn sign;
        FormAboutTheCinema about;
        FormFilmAbout buy;         
        public FormBuyTickets()
        {
            InitializeComponent();
            Person.Load();           
            Hall.Load();
            HallSector.Load();
            HallPlace.Load();         
            HallPerson.Load();
            Film.Load();
            Person.Load();
            Ticket.Load();           
            PersonTicket.Load();
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

        private void FormBuyTickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Person.Save();            
            Hall.Save();
            HallSector.Save();
            HallPlace.Save();
            HallSpace.Save();
            HallAdding.Save();
            HallPerson.Save();
            Film.Save();
            Person.Save();
            Ticket.Save();           
            PersonTicket.Save();
        }
    }
}
