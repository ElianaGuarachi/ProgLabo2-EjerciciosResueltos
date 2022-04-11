using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI03_Contador
{
    public partial class FrmContadorPalabras : Form
    {
        public FrmContadorPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();
            podio.Sort(CompararCantidadRepeticiones);

            MostrarPodio(podio);
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder stringB = new StringBuilder();
            foreach (KeyValuePair<string,int> par in podio)
            {
                stringB.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
            }
            MessageBox.Show(stringB.ToString(), "Podio");
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string,int> primerElemento, KeyValuePair<string,int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value ;
        }

        private Dictionary<string,int> ObtenerContadorPalabras()
        {
            string texto = rtxtContadorPalabras.Text;
            string[] palabras = texto.Split(' '); //separa y guarda en el array

            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras) //recorro el array
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++; //palabra es el indice
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }
            }

            return contadorPalabras;
        }
    }
}
