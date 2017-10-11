using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms5
{
    public partial class BestOil : Form
    {
        private int petrol72 = 25;
        private int petrol80 = 28;
        private int petrol92 = 38;
        private int petrol93 = 39;
        private int petrol95 = 40;
        private int petrol98 = 42;
        private int petrolDT = 38;
        public BestOil()
        {
            InitializeComponent();
        }

        private void ComboBoxOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOil.Text == "АИ-72")
            {
                textBoxPrice.Text = petrol72.ToString();
                textBoxPriceLiter.Focus();
            }

            else if (comboBoxOil.Text == "АИ-80")
            {
                textBoxPrice.Text = petrol80.ToString();
                textBoxPriceLiter.Focus();
            }

            else if (comboBoxOil.Text == "АИ-92")
            {
                textBoxPrice.Text = petrol92.ToString();
                textBoxPriceLiter.Focus();
            }

            else if (comboBoxOil.Text == "АИ-93")
            {
                textBoxPrice.Text = petrol93.ToString();
                textBoxPriceLiter.Focus();
            }

            else if (comboBoxOil.Text == "АИ-95")
            {
                textBoxPrice.Text = petrol95.ToString();
                textBoxPriceLiter.Focus();
            }

            else if(comboBoxOil.Text == "АИ-98")
            {
                textBoxPrice.Text = petrol98.ToString();
                textBoxPriceLiter.Focus();
            }

            else if (comboBoxOil.Text == "ДТ")
            {
                textBoxPrice.Text = petrolDT.ToString();
                textBoxPriceLiter.Focus();
            }
        }

        private void RadioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrice.Checked)
            {
                panelPaymentone.Text = "К выдаче:";
                textBoxPriceLiter.Enabled = false;
                textBoxPriceRub.Enabled = true;
                textBoxPriceRub.Focus();
                labelOilLiter.Text = "л.";
            }
            else
            {
                textBoxPriceLiter.Text = null;
                textBoxPriceLiter.Enabled = false;
            }
        }

        private void RadioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQuantity.Checked)
            {
                panelPaymentone.Text = "К оплате:";
                textBoxPriceRub.Enabled = false;
                textBoxPriceLiter.Enabled = true;
                textBoxPriceLiter.Focus();
            }
            else
            {
                textBoxPriceLiter.Text = null;
                textBoxPriceLiter.Enabled = false;
            }
        }
    }
}
