using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmReloj : Form
    {
        private Temporizador temporizador;

        public FrmReloj()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);

            //metodo asociado al evento
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void ActualizarHora(DateTime dateTime)
        {
            
        }

        private void AsignarHora()
        {
            //Invoke required sera true si estamos en un hilo de ejecucion
            //distinto al hilo donde se instancio el control o formulario
            //false si estamos en el mismo hilo
            if (lblHora.InvokeRequired)
            {
                //Guardo en un delegado el metodo que quiero llamar
                //desde el hilo donde se instancio el control/formulario
                Action asignarHora = AsignarHora;

                //Invoke para ejecutar ese metodo
                //(el que esta referenciado delegado)
                //desde el hilo donde se creo el control o formulario
                lblHora.Invoke(asignarHora);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:MM:ss");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }
    }
}
