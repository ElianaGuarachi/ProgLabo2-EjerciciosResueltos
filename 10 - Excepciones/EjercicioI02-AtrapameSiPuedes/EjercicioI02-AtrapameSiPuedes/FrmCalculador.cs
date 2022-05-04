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

namespace EjercicioI02_AtrapameSiPuedes
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLitros.Text == "" || this.txtKilometros.Text == "") //lanzamos una excepcion
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio");
                }

                this.rtbCalculador.Text = $"km / hs {Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text))}";
            }
            catch (ParametrosVaciosException ex) //captura la excecion
            {
                MessageBox.Show(ex.Message);//informa
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
