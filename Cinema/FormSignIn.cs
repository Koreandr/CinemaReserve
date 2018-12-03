using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            cBCode.Text = Convert.ToString(0);
        }
        Person person;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (dateTimeYear.Value < DateTime.Now)
            {
                string code = cBCode.Text + tBAdvantage.Text;
                if (tBName.Text != "" && TbSName.Text != "" && tBAdvantage.Text.Length == 8 && dateTimeYear.Value != DateTime.Now && cBCode.SelectedIndex >= 0)
                {
                    person = new Person(tBName.Text, TbSName.Text, code, dateTimeYear.Value);
                    LB();
                }
                else if (tBName.Text != "" && TbSName.Text != "" && dateTimeYear.Value != DateTime.Now)
                {
                    person = new Person(tBName.Text, TbSName.Text, code, dateTimeYear.Value);
                    LB();
                }
                else
                {
                    MessageBox.Show("Please input all fields", "Input all information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Date must be before today", "Etantiom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LB()
        {
            tBCode.Text = "Your code is : " + person.GetCode;
            tBPercent.Text = "Your advantage is : " + person.Percent + "%";
        }
        private void CheckInput(TextBox tb)
        {
            string pattern = @"^\d*,?\d*$";
            Match mc = Regex.Match(tb.Text, pattern);
            bool isdontwantsym = mc.Success;
            if (!isdontwantsym)
            {
                MessageBox.Show("Please input the number", "Etantion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Text = "";
            }
        }
        private void tBAdvantage_TextChanged(object sender, EventArgs e)
        {
            tBAdvantage.MaxLength = 8;
            CheckInput(tBAdvantage);

        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            cBCode.Text = "";
        }
    }
    
}

