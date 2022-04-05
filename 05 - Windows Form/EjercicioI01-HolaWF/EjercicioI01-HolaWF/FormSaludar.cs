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
    public partial class FormSaludar : Form
    {
        public FormSaludar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonSaludar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.textNombre.Text) && !string.IsNullOrWhiteSpace(this.textApellido.Text))
            {
                FrmSaludo frm = new FrmSaludo("Hola Windows Form!", $"Soy {this.textNombre.Text} {this.textApellido.Text} " +
                $"y mi materia favorita es {this.comboBox1.SelectedItem}");
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Se debe completar los siguientes campos\n {this.textNombre.Text}\n { this.textApellido.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSaludar_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Programacion II");
            this.comboBox1.Items.Add("Laboratorio II");
            this.comboBox1.Items.Add("Estadistica II");

            this.comboBox1.SelectedIndex = 0;
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                this.lblError.Visible = true;
            }
            else
            {
                this.lblError.Visible = false;
            }
        }
    }
}
