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
            string litros = this.txtLitros.Text;
            string kilometros = this.txtKilometros.Text;
            try
            {
                if (string.IsNullOrEmpty(litros) ||  string.IsNullOrEmpty(kilometros)) 
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio"); //lanzamos (creamos) una excepcion
                }

                int resultado = Calculador.Calcular(int.Parse(kilometros), int.Parse(litros));

                if (resultado == -1)
                {
                    throw new Exception("Los valores no pueden ser negativos");
                }
                this.rtbCalculador.Text = $"km / hs {resultado}";
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
