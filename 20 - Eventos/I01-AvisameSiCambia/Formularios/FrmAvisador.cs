using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmAvisador : Form
    {
        Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                btn_Crear.Text = "Actualizar";
            }

            if (txb_Apellido.Text != persona.Apellido)
            {
                persona.Apellido = txb_Apellido.Text;
            }

            if (txb_Nombre.Text != persona.Nombre)
            {
                persona.Nombre = txb_Nombre.Text;
            }
            
            lbl_NombreCompleto.Text = persona.Mostrar();
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
