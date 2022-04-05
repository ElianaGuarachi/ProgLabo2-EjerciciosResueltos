using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01_HolaWF
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        public FrmSaludo(string titulo, string mensaje) : this()
        {
            this.lblTitulo.Text = titulo;
            this.lblSaludar.Text = mensaje;
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {

        }
    }
}
