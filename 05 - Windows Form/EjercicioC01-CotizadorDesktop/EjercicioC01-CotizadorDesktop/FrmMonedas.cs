using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace EjercicioC01_CotizadorDesktop
{
    public partial class FrmMonedas : Form
    {
        public FrmMonedas()
        {
            InitializeComponent();
        }


        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;

            if(double.TryParse(txtEuro.Text, out cantidad))
            {
                Euro euro = new Euro(cantidad);

                txtEuroAEuro.Text = $"{cantidad}";
                txtEuroADolar.Text = $"{((Dolar)euro).ToString()}";
                txtEuroAPeso.Text = ((Pesos)euro).ToString();

            }
            
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {

        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(this.btnLockCotizacion.ImageIndex == 0)
            {
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                this.btnLockCotizacion.ImageIndex = 1;
                               
            }
            else
            {
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
                txtCotizacionPeso.Enabled = false;
                this.btnLockCotizacion.ImageIndex = 0;
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {

        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {

        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {

        }
    }
}
