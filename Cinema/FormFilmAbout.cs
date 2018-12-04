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
        List<Square> list = new List<Square>();
        public FormFilmAbout()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FormTicketCheck newForm = new FormTicketCheck();
            newForm.Show();
        }
        public double Code(string x)
        {
            double percent = 0;
            string z;
            foreach (var item in Person.Items.Values)
            {
                z = item.GetCode.ToString();
                if (x == z)
                    percent = item.Percent;
            }
            return percent;
        }

        private void FormFilmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
