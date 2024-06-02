using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string nit;

        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.nit = "";
        }



        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nit { get => nit; set => nit = value; }
    }
}
