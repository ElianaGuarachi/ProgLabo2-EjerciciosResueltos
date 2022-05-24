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
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSupermercado;
        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void ConfigurarToolTips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTipAgregar = new ToolTip();
            ToolTip toolTipEliminar = new ToolTip();
            // In this example, button1 is the control to display the ToolTip.
            toolTipAgregar.SetToolTip(btnAgregar, "Agregar objeto");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar objeto");
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ConfigurarToolTips();
        }

        private void AgregarObjeto()
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
            }
        }

        private void EliminarObjeto()
        {
            /*
             * Al accionarlo deberá borrar el objeto seleccionado en la lista. Si no hay nada seleccionado, 
             * no hacer nada y mostrar un cartel informando que se debe seleccionar un elemento de la lista.
             * */

            string seleccion = lstObjetos.SelectedItem as string;
            if (seleccion is not null)
            {
                listaSupermercado.Remove(seleccion);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ModificarObjeto()
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarObjeto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarObjeto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarObjeto();
        }
    }
}
