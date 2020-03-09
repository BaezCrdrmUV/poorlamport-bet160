using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RelojLogico
{
    public partial class MainWindow : Window
    {
        private List<Proceso> procesos = new List<Proceso>();

        public MainWindow()
        {
            InitializeComponent();
            CrearProcesos();
        }

        private void CrearProcesos() {
            Proceso proceso;

            for (int i = 0; i < 4; i++)
            {
                proceso = new Proceso();
                procesos.Add(proceso);
            }
        }

        private void EnviarMensaje(int emisor, int receptor, string mensaje, string mensajeRecepcion) 
        {
            procesos[emisor].Contador += 1;
            procesos[emisor].Mensaje = mensaje;
            RecibirMensaje(emisor, receptor, mensajeRecepcion);
        }

        private void RecibirMensaje(int emisor, int receptor, string mensaje)
        {
            if(procesos[emisor].Contador > procesos[receptor].Contador)
            {
                procesos[receptor].Contador = procesos[emisor].Contador + 1;
            }
            else
            {
                procesos[receptor].Contador += 1;
            }

            procesos[receptor].Mensaje = mensaje;
        }

        private void MostrarHistorialProcesoUno()
        {
            DG1.Items.Add(procesos[0]);  
        }

        private void MostrarHistorialProcesoDos()
        {
            DG2.Items.Add(procesos[1]);
        }

        private void MostrarHistorialProcesoTres()
        {
            DG3.Items.Add(procesos[2]);
        }

        private void MostrarHistorialProcesoCuatro()
        {
            DG4.Items.Add(procesos[3]);
        }

        private void ActualizarTabla(int numeroProcesoEmisor, int numeroProcesoReceptor) 
        {
            if(numeroProcesoEmisor == 0 || numeroProcesoReceptor == 0)
            {
                MostrarHistorialProcesoUno();
            }
            if (numeroProcesoEmisor == 1 || numeroProcesoReceptor == 1)
            {
                MostrarHistorialProcesoDos();
            }
            if (numeroProcesoEmisor == 2 || numeroProcesoReceptor == 2)
            {
                MostrarHistorialProcesoTres();
            }
            if (numeroProcesoEmisor == 3 || numeroProcesoReceptor == 3)
            {
                MostrarHistorialProcesoCuatro();
            }
        }

        public void LimpiarTexBox()
        {
            TBEmisor.Clear();
            TBReceptor.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int emisor = int.Parse(TBEmisor.Text) - 1;
            int receptor = int.Parse(TBReceptor.Text) - 1;
            string mensajEnvio = "Mensaje enviado";
            string mensajeRecepcion = "Mensaje recibido";

            EnviarMensaje(emisor, receptor, mensajEnvio, mensajeRecepcion);
            ActualizarTabla(emisor, receptor);
            LimpiarTexBox();
        }
    }
}
