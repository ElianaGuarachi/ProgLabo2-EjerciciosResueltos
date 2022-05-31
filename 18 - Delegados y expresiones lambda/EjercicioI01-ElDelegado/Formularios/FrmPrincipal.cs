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
    public partial class FrmPrincipal : Form
    {
        //declaro variables formularios
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //instancio las variables formularios
            frmMostrar = new FrmMostrar();
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);

            //propiedad MdiParent
            frmMostrar.MdiParent = this;
            frmTestDelegados.MdiParent = this;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestro el formulario de TestDelegados
            frmTestDelegados.Show();

            //Habilito la opcion mostrar del menu
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra el formulario mostrar al hacer click en la opcion de mostrar del menu
            frmMostrar.Show();
        }
    }
}
