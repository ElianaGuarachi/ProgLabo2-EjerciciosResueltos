using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Central;

namespace Formulario
{
    public partial class FrmMenu : Form
    {
        public Centralita central;

        public FrmMenu()
        {
            InitializeComponent();
            central = new Centralita("Nueva Central");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Seguro de querer salir?";
            string titulo = "Salir";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador nuevaForm = new FrmLlamador(this.central);
            nuevaForm.ShowDialog();
        }

        private void btnFacTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar nuevaForm = new FrmMostrar(this.central);
            nuevaForm.ShowDialog();
        }

        private void btnFacLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar nuevaForm = new FrmMostrar(this.central);
            nuevaForm.ShowDialog();
        }

        private void btnFacProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar nuevaForm = new FrmMostrar(this.central);
            nuevaForm.ShowDialog();
        }
    }
}
