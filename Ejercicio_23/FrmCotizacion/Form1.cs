using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Moneda;

namespace FrmCotizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(btnLockCotizacion.ImageIndex == 0)
            {
                btnLockCotizacion.ImageIndex = 1;//habilitado
                txtBCotizEuro.Enabled = true;
                txtBCotizPeso.Enabled = true;
            }
            else
            {
                btnLockCotizacion.ImageIndex = 0;//deshabilitado
                txtBCotizEuro.Enabled = false;
                txtBCotizPeso.Enabled = false;
            }
            
        }

        private void txtBCotizEuro_Leave(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = double.TryParse(txtBCotizEuro.Text, out n);

            if (isNumeric)
            {
                Euro.SetCotizacion(n);
            }
            else
            {
                txtBCotizEuro.Select();
            }

            
        }

        private void txtBCotizPeso_Leave(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = double.TryParse(txtBCotizPeso.Text, out n);

            if (isNumeric)
            {
                Pesos.SetCotizacion(n);
            }
            else
            {
                txtBCotizPeso.Select();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (txtBEuros.Text != null && btnLockCotizacion.ImageIndex == 0)
            {
                //validar que sea num:
                double n;
                bool isNumeric = double.TryParse(txtBEuros.Text, out n);
                if (isNumeric)
                {
                    txtBEuroaEuro.Text = n.ToString();
                    txtBEuroADolar.Text = ((Dolar)((Euro)n)).GetCantidad().ToString();
                    txtEuroAPeso.Text = ((Pesos)((Euro)n)).GetCantidad().ToString();
                }
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (txtBDolares.Text != null && btnLockCotizacion.ImageIndex == 0)
            {
                //validar que sea num:
                double n;
                bool isNumeric = double.TryParse(txtBDolares.Text, out n);
                if (isNumeric)
                {
                    txtBDolarAEuro.Text = ((Euro)((Dolar)n)).GetCantidad().ToString();
                    txtBDolarADolar.Text = n.ToString();
                    txtBDolarAPeso.Text = ((Pesos)((Dolar)n)).GetCantidad().ToString();
                }
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (txtBPesos.Text != null && btnLockCotizacion.ImageIndex == 0)
            {
                //validar que sea num:
                double n;
                bool isNumeric = double.TryParse(txtBPesos.Text, out n);
                if (isNumeric)
                {
                    txtBPesoAEuro.Text = ((Euro)((Pesos)n)).GetCantidad().ToString();
                    txtBPesoADolar.Text = ((Dolar)((Pesos)n)).GetCantidad().ToString();
                    txtBPesoAPeso.Text = n.ToString();
                }
            }
        }
    }
}
