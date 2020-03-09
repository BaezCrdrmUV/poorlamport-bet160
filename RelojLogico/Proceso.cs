using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojLogico
{
    class Proceso
    {
        private int id;
        private int contador;
        private string mensaje;

        public Proceso()
        {
            this.contador = 0;
        }

        public int Id { get => id; set => id = value; }
        public int Contador { get => contador; set => contador = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
