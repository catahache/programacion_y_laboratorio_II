using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemasNumeracion;


namespace FrmConversor
{
    public partial class FrmSistemasNumericos : Form
    {
        public FrmSistemasNumericos()
        {
            InitializeComponent();
        }

        private void btnBinADec_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(txtBBinADecIN.Text, out int bin);
            if (isNumeric)
            {
                //recorrer array para ver si solo son 1 y 0
                bool isBinario = true;
                foreach (char item in bin.ToString())
                {
                    if(item != '0' && item != '1')
                    {
                        isBinario = false;
                        break;
                    }
                }

                if (isBinario)
                {
                    txtBBinADecOUT.Text = (Conversor.BinarioDecimal(bin.ToString())).ToString();
                }
            }
        }

        private void btnDecABin_Click(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(txtBDecABinIN.Text, out int dec);
            if (isNumeric)
            {
                txtBDecABinOUT.Text = Conversor.DecimalBinario(dec);
            }
        }
    }
}
