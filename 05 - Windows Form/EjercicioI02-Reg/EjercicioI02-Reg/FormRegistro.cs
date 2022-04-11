using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace EjercicioI02_Reg
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        public string ElegirSexo()
        {
            if (radioButton1.Checked == true)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                return radioButton2.Text;
            }
            else
            {
                return radioButton3.Text;
            }
        }

        public string[] ElegirCursos()
        {
            string[] cursos = new string[3];

            if (this.checkBoxC.Checked)
            {
                cursos[0] = $"{this.checkBoxC.Text}";
            }

            if (this.checkBox2.Checked)
            {
                cursos[1] = $"{this.checkBox2.Text}";
            }

            if (this.cBoxJavaScript.Checked)
            {
                cursos[2] = $"{this.cBoxJavaScript.Text}";
            }

            return cursos;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtDireccion.Text))
            {    
                Ingresante e1 = new Ingresante($"{this.txtNombre.Text}", $"{this.txtDireccion.Text}", 
                    $"{ElegirSexo()}", $"{IngresarNacionalidad()}", (int)numEdad.Value, ElegirCursos());
                MessageBox.Show(e1.Mostrar());
            }
            else
            {
                MessageBox.Show("Debe completar los datos como corresponde.");
            }
        }

        public string IngresarNacionalidad()
        {
            return listBoxPais.SelectedItem.ToString();
        }

    }
}
