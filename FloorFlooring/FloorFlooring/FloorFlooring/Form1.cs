using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloorFlooring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lengthfeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lengthinch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void widthfeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void widthinch_TextChanged(object sender, EventArgs e)
        {
        }

        private void widthinch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void pricebtn_Click(object sender, EventArgs e)
        {
            double lengthinfeet = (Convert.ToDouble(lengthfeet.Text)) + ((Convert.ToDouble(lengthinch.Text))/12);
            double widthinfeet = (Convert.ToDouble(widthfeet.Text)) + ((Convert.ToDouble(widthinch.Text)) / 12);
            double area = lengthinfeet * widthinfeet;
            double matrate = new double();
            switch (hardwoodprices.SelectedIndex)
            {
                case 0:
                    matrate = 30.75;
                    break;
                case 1:
                    matrate = 34.90;
                    break;
                case 2:
                    matrate = 35.50;
                    break;
                case 3:
                    matrate = 41.20;
                    break;
            }
            switch (carpetprices.SelectedIndex)
            {
                case 0:
                    matrate = 15.35;
                    break;
                case 1:
                    matrate = 20.25;
                    break;
                case 2:
                    matrate = 21.99;
                    break;
                case 3:
                    matrate = 25.24;
                    break;
            }
            switch (laminateprices.SelectedIndex)
            {
                case 0:
                    matrate = 10;
                    break;
                case 1:
                    matrate = 12.5;
                    break;
            }
            double price = area * (matrate/3);
            mathcheck.Text = Convert.ToString(price);
        }
          public void hardwoodprices_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

         public void carpetprices_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       public void laminateprices_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            lengthfeet.Text= "";
           lengthinch.Text = "";
            widthfeet.Text = "";
            widthinch.Text = "";
        }
    }
}
