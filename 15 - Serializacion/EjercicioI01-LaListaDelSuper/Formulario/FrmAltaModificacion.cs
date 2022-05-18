using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string titulo, string contenidoTxtbox, string TextoBotonConfirmar)
        {
            InitializeComponent();
            Text = titulo;
            txtObjeto.Text = contenidoTxtbox;
            btnConfirmar.Text = TextoBotonConfirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("El texto no puede estar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 es el código ASCII que representa a ENTER.
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27) //27 es ASCII es ESC
            {
                Cancelar();
            }
        }
    }
}
