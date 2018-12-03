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
    public partial class FormFilmAbout : Form
    {
        FormTicketCheck check;
        List<Square> list = new List<Square>()
        public FormFilmAbout()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FormFinishTicket newForm = new FormFinishTicket();
            newForm.Show();
        }

        private void FormFilmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
