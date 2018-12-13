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
    public partial class FormTicketCheck : Form
    {
        static int i=0;
        public FormTicketCheck()
        {
            InitializeComponent();
            Ticket ticket = new Ticket();
            lblDBuy.Text = ticket.ToString();

            foreach (var item in Ticket.Items.Values)
            {
                i++;
                if (item == Ticket.Items.Values.Last())
                {
                    lblPrice.Text = "Price : " + item.Price;
                    foreach (var elem in item.Hall.HallSectors)
                    {
                        if (elem.Price == item.Price)
                        {
                            lblSector.Text = "Sector : " + elem.Name;
                        }
                    }
                    foreach (var elem in HallPlace.Items.Values)
                    {
                        if (elem.Id == item.IdPlace)
                        {
                            lblPlace.Text = "Place : " + elem.Place;
                        }
                    }
                    lblPref.Text = "Preferential : " + item.Answer;
                    lblHall.Text = "Hall : " + item.Hall.Name;
                    lblFilm.Text = item.Film.Name;
                }

            }
        }

        private void FormTicketCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
