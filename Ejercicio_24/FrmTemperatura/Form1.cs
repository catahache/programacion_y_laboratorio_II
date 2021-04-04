using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UnidadesTemperatura;

namespace FrmTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(txtBFahrenheit.Text, out double f);
            if (isNumeric)
            {
                txtBFaF.Text = f.ToString();
                txtBFaC.Text = (((Celsius)((Fahrenheit)f)).GetGrados()).ToString();
                txtBFaK.Text = (((Kelvin)((Fahrenheit)f)).GetGrados()).ToString();
            }
            else
            {
                //txtBFahrenheit.Focus();
            }
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(txtBCelsius.Text, out double c);
            if (isNumeric)
            {
                txtBCaC.Text = c.ToString();
                txtBCaF.Text = (((Fahrenheit)((Celsius)c)).GetGrados()).ToString();
                txtBCaK.Text = (((Kelvin)((Celsius)c)).GetGrados()).ToString();
            }
            else
            {
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(txtBKelvin.Text, out double k);
            if (isNumeric)
            {
                txtBKaK.Text = k.ToString();
                txtBKaF.Text = (((Fahrenheit)((Kelvin)k)).GetGrados()).ToString();
                txtBKaC.Text = (((Celsius)((Kelvin)k)).GetGrados()).ToString();
            }
            else
            {
            }
        }
    }
}
