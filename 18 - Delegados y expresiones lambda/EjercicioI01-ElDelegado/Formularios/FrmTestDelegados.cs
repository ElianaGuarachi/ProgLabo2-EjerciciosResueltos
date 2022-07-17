using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmTestDelegados : Form
    {
        //Firma del delegado
        public delegate void ActualizarNombreDelegate(string nombre);

        //declaro una variable tipo delegado
        private ActualizarNombreDelegate actualizarNombreDelegate;

        //Delegado como parametro 
        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
        {
            this.actualizarNombreDelegate = actualizarNombreDelegate;
            InitializeComponent();         
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    actualizarNombreDelegate.Invoke(txtNombre.Text);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }
    }
}
