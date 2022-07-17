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

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        CancellationTokenSource cancellation;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AsignarHora(CancellationTokenSource cancellation)
        {
            do
            {
                this.ActualizarHora(DateTime.Now);
                Thread.Sleep(1000);
            } while (!cancellation.IsCancellationRequested);
            //mientras no se requiera cancelacion
        }

        //delegate void DelegateHora(DateTime dateTime);

        private void ActualizarHora(DateTime dateTime)
        {
            if (this.InvokeRequired)
            {
                //DelegateHora callback = new DelegateHora(ActualizarHora);
                Action<DateTime> callback = new Action<DateTime>(ActualizarHora);
                object[] arrayCallback = { dateTime };
                this.BeginInvoke(callback, arrayCallback);
            }
            else
            {
                this.lblHora.Text = $"Hora: {dateTime}";
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;

            Task.Run(() => AsignarHora(cancellation),token);

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            cancellation.Cancel();
        }
    }
}
