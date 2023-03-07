using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int get_size_price()
        {
            if (rdBtnSizeSmall.Checked)
            {
                return Convert.ToInt32(rdBtnSizeSmall.Tag) ;
            }
            else if (rdBtnSizeMedium.Checked)
            {
                return Convert.ToInt32(rdBtnSizeMedium.Tag);
            }
            else
            {
                return Convert.ToInt32(rdBtnSizeLarge.Tag);
            }
        }
        int get_crust_price()
        {
            if (rdBtnCrustThin.Checked)
            {
                return Convert.ToInt32(rdBtnCrustThin.Tag);
            }
            else
            {
                return Convert.ToInt32(rdBtnCrustThink.Tag);
            }
        }
        string  update_toppings()
        {
            string value ="";
            if (chkBoxExtCheese.Checked)
            {
                value+= chkBoxExtCheese.Text;
            }
            if (chkBoxTomatoes.Checked)
            {
                if (value=="")
                {
                    value += chkBoxTomatoes.Text;
                }
                else
                {
                    value += ", " + chkBoxTomatoes.Text;
                }
            }
            if (chkBoxOnion.Checked)
            {
                if (value == "")
                {
                    value += chkBoxOnion.Text;
                }
                else
                {
                    value += ", " + chkBoxOnion.Text;
                }
            }
            if (chkBoxOlives.Checked)
            {
                if (value == "")
                {
                    value += chkBoxOlives.Text;
                }
                else
                {
                    value += ", " + chkBoxOlives.Text;
                }
            }
            if (chkBoxMushrooms.Checked)
            {
                if (value == "")
                {
                    value += chkBoxMushrooms.Text;
                }
                else
                {
                    value += ", " + chkBoxMushrooms.Text;
                }
            }
            if (chkBoxGrnPeppers.Checked)
            {
                if (value == "")
                {
                    value += chkBoxGrnPeppers.Text;
                }
                else
                {
                    value += ", " + chkBoxGrnPeppers.Text;
                }
            }
            return value;
        }
        int get_toppings_price()
        {
            int size = 0;
            if (chkBoxExtCheese.Checked)
            {
                size += Convert.ToInt32(chkBoxExtCheese.Tag);
            }
            if (chkBoxTomatoes.Checked)
            {
                size += Convert.ToInt32(chkBoxTomatoes.Tag);
            }
            if (chkBoxOnion.Checked)
            {
                size += Convert.ToInt32(chkBoxOnion.Tag);
            }
            if (chkBoxMushrooms.Checked)
            {
                size += Convert.ToInt32(chkBoxMushrooms.Tag);
            }
            if (chkBoxOlives.Checked)
            {
                size += Convert.ToInt32(chkBoxOlives.Tag);
            }
            if (chkBoxGrnPeppers.Checked)
            {
                size += Convert.ToInt32(chkBoxGrnPeppers.Tag);
            }
            return size;
        }
        int get_price()
        {
            return get_size_price()+get_crust_price()+get_toppings_price();
        }

        private void labTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdBtnSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSizeSmall.Checked)
            {
                labSizeRes.Text = rdBtnSizeSmall.Text;
                labTprice.Text = get_price().ToString();
            }
        }
        private void chkBoxExtCheese_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }

        private void labSizeRes_Click(object sender, EventArgs e)
        {
        }

        private void rdBtnSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            if(rdBtnSizeMedium.Checked)
            {
                labSizeRes.Text = rdBtnSizeMedium.Text;
                labTprice.Text = get_price().ToString();
            }
        }

        private void rdBtnSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            if(rdBtnSizeLarge.Checked)
            {
                labSizeRes.Text = rdBtnSizeLarge.Text;
                labTprice.Text = get_price().ToString();
            }
        }

        private void rdBtnCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCrustThin.Checked)
            {
                lab.Text = rdBtnCrustThin.Text;
                labTprice.Text = get_price().ToString();
            }
        }

        private void rdBtnCrustThink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCrustThink.Checked)
            {
                lab.Text = rdBtnCrustThink.Text;
                labTprice.Text = get_price().ToString();
            }
        }

        private void rdBtnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnEatIn.Checked)
            {
                    label3.Text = rdBtnEatIn.Text;
            }
        }

        private void rdBtnTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnTakeOut.Checked)
            {
                label3.Text = rdBtnTakeOut.Text;
            }
        }

        private void labWtoEatRes_Click(object sender, EventArgs e)
        {

        }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }

        private void chkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }

        private void chkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }

        private void chkBoxGrnPeppers_CheckedChanged(object sender, EventArgs e)
        {
            labTopRes.Text = update_toppings();
            labTprice.Text = get_price().ToString();
        }
    }
}
