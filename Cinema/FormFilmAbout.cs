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
    public partial class FormFilmAbout : Form
    {
        FormTicketCheck check;
        List<Square> list = new List<Square>();
        public FormFilmAbout()
        {
            InitializeComponent();
            refreshAll();
         //   DelOldPeople();
            Clear();
        }
        
        public void Places()
        {
            if (cBCinema.SelectedItem != null)
            {
                int size = 0;
                foreach (var item in ((Hall)cBCinema.SelectedItem).HallSectors)
                {
                    size += item.HallPlaces.Count;
                }
                Point point = new Point(50, 50);
                int index1 = 0;
                int count = 0;
                int Index = 0;
                bool ifSold = false;
                int length = Convert.ToInt32(340 / Math.Sqrt(size));
                int x = 0;
                int y = 0;
                double result = Math.Sqrt(size);
                int index = 0;
                for (int i = 0; i < size; i++)
                {
                    if (Math.Sqrt(size) == (Int32)result)
                    {
                        x = (Int32)result;
                        y = x;
                        break;
                    }
                    else
                    {
                        index++;
                        size--;
                    }
                }
                for (int i = 0; x <= index; i++)
                {
                    index -= x;
                    x++;
                }
                Hall h = (Hall)cBCinema.SelectedItem;
                double z = (x - index) / 2;
                for (int i = 0; i <= y; i++)
                {

                    for (int j = 0; j < x; j++)
                    {
                        Index++;
                        if (i < x)
                        {
                            if ((h).HallSectors.Count == index1)
                            {
                                break;
                            }
                            else
                            {
                                if ((h).HallSectors[index1].HallPlaces.Count != count)
                                {
                                    Square sq1 = null;
                                    foreach (var item in h.HallSectors[index1].HallPlaces)
                                    {
                                        if (item.Place == Index && item.IsSold == true)
                                        {
                                            ifSold = true;
                                        }
                                    }
                                    if (ifSold == true)
                                    {
                                        sq1 = new Square(Color.Red, length, length);
                                    }
                                    else if (ifSold == false)
                                    {
                                        sq1 = new Square(h.HallSectors[index1].Color, length, length);
                                    }
                                    Controls.Add(sq1);
                                    sq1.Location = new Point(point.X + j * (length + 1), point.Y + i * (length + 1));
                                    list.Add(sq1);
                                    ifSold = false;
                                    count++;
                                }
                                else
                                {
                                    index1++;
                                    if (j != 0)
                                    {
                                        j--;
                                    }
                                    else
                                    {
                                        i--;
                                        j = x - 1;
                                    }
                                    Index--;
                                    count = 0;
                                }

                            }
                        }

                        else
                        {
                            for (int k = 0; k < index; k++)
                            {
                                if (index1 != h.HallSectors.Count)
                                {
                                    Square sq1 = new Square(h.HallSectors[index1].Color, length, length);
                                    sq1.Height = length;
                                    sq1.Width = length;
                                    Controls.Add(sq1);
                                    sq1.Location = new Point(point.X + (Int32)(length * z + k) + k * (length + 1), point.Y + (x) * (length + 1));
                                    list.Add(sq1);
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Index = i;
                    list[i].MouseClick += Control_MouseClick;
                }
            }
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
        //public void DelOldPeople()
        //{
        //    foreach (var item in SessionFilm.Items.Values)
        //    {
        //        if (item.Film.End < DateTime.Now)
        //        {
        //            HallPerson.Items.Remove((item.Hall).DelId);
        //        }
        //    }
        //}
        public void Clear()
        {
            tBFilm.Text = null;
            tBCard.Text = null;
            TbCode.Text = null;
            tBPrice.Text = null;
        }
        public void refreshAll()
        {
            cBCinema.DataSource = null;
            cBCinema.DataSource = Hall.Items.Values.ToList();
        }

        List<HallPlace> lst = new List<HallPlace>();
        
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

        private void tBCard_TextChanged(object sender, EventArgs e)
        {

            tBCard.MaxLength = 19;
            if (tBCard.TextLength == 4 || tBCard.TextLength == 9 || tBCard.TextLength == 14)
            {
                tBCard.Text += "-";
                tBCard.Select(tBCard.TextLength, 0);
            }
        }

        private void TbCode_TextChanged(object sender, EventArgs e)
        {
            CheckInput(TbCode);
            TbCode.MaxLength = 8;
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (sender.Equals(list[i]))
                {
                    index = 0;
                    if (list[i].color == Color.Black)
                    {
                        foreach (var item in ((Hall)cBCinema.SelectedItem).HallSectors)
                        {
                            foreach (var elem in item.HallPlaces)
                            {
                                if (i == index && elem.IsSold == true)
                                {
                                    list[i].color = Color.Red;
                                    list[i].Refresh();
                                    tBPlace.Text = "";
                                }
                                else if (i == index)
                                {
                                    list[i].color = item.Color;
                                    list[i].Refresh();
                                    tBPlace.Text = "";
                                }
                                index++;
                            }
                        }
                    }
                    else
                    {
                        list[i].color = Color.Black;
                        list[i].Refresh();
                        tBPlace.Text = (i + 1).ToString();
                    }
                }

            }
        }

       

        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            FormTicketCheck newForm = new FormTicketCheck();
            newForm.Show();
            HallPlace place = null;
            if (tBPlace.Text != "" && TbCode.Text != "" && tBCard.Text != "")
            {
                foreach (var item in ((Hall)cBCinema.SelectedItem).HallSectors)
                {
                    foreach (var elem in item.HallPlaces)
                    {
                        if (elem.Place == Int32.Parse(tBPlace.Text))
                        {
                            place = elem;
                            break;
                        }
                    }
                }
                if (place.IsSold == false)
                {
                    if (tBFilm.Text != "")
                    {
                        bool b = false;
                        string z;
                        double price = place.HallSector.Price;
                        place.IsSold = true;
                        foreach (var item in Person.Items.Values)
                        {
                            z = item.GetCode.ToString();
                            if (TbCode.Text == z)
                            {
                                b = true;
                            }
                        }

                        Clear();
                        check = new FormTicketCheck();
                        check.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("There are any films in this hall", "Sorry",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("This place is already sold");
                }
            }
            else
            {
                MessageBox.Show("Please select and input all fields", "Etantion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cBCinema_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lst.Clear();
            foreach (var item in list)
            {
                Controls.Remove(item);
            }
            list.Clear();
            Places();
            tBFilm.Text = null;
            foreach (var item in ((Hall)cBCinema.SelectedItem).HallSectors)
            {
                lst.AddRange(item.HallPlaces);
            }

        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            double x = 0;
            double z = 0;
            
           
            HallPlace place = null;
            if (tBPlace.Text != "" && TbCode.Text != "")
            {
                foreach (var item in HallPlace.Items.Values)
                {
                    if (Int32.Parse(tBPlace.Text) == item.Place)
                    {
                        place = item;
                    }
                }
                if (place.IsSold == false)
                {
                    if (tBFilm.Text != "")
                    {
                        foreach (var item in Hall.Items.Values)
                        {
                            foreach (var price in item.HallSectors)
                            {
                                foreach (var places in price.HallPlaces)
                                {
                                    if (place == places)
                                    {
                                        x = price.Price;
                                    }
                                }
                            }
                        }
                        if (tBAmountP.Text == null)
                        {
                            MessageBox.Show("Please select and input all fields", "Etantion",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int g = Int32.Parse(tBAmountP.Text);
                            double k = Code(TbCode.Text);
                        if (k == 0)
                            z = x;
                        else
                            z = g * x * k / 100;
                        tBPrice.Text = z + "UAH";
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are any films in this hall", "Sorry",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("This place is sold", "Etantion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Please select and input all fields", "Etantion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
