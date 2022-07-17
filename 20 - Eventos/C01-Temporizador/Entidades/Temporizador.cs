using System;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();

        public event DelegadoTemporizador TiempoCumplido;

        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        private Task hilo;
        private int intervalo;

        public bool EstaActivo
        {
            get 
            {
                return hilo is not null && hilo.Status == TaskStatus.Running;
            }
        }

        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        private void CorrerTiempo()
        {           
            do
            {
                if (TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke(); //llamada del evento
                    Thread.Sleep(intervalo);
                }
                
            } while (!cancellationTokenSource.IsCancellationRequested);
        }

        public void DetenerTemporizador()
        {
            if (EstaActivo)
            {
                cancellationTokenSource.Cancel();
            }
        }

        public void IniciarTemporizador()
        {
            if (!EstaActivo)
            {                
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;

                hilo = new Task(CorrerTiempo, cancellationToken);
            
                hilo.Start();
            }
        }



    }
}
