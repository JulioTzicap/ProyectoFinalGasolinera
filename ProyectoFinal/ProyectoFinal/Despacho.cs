using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Despacho
    {
        private Cliente cliente;
        private Bomba bomba;
        private TipoDeDespacho tipoDeDespacho;
        private DateTime fechaHora;
        private double precioDia;
        private double cantidadDespacho;
        private double total;
        private Despacho siguiente;

        public Despacho()
        {
            this.cliente = new Cliente();
            this.bomba = new Bomba();
            this.tipoDeDespacho = new TipoDeDespacho();
            this.fechaHora = DateTime.Now; 
            this.precioDia = 0.0;
            this.cantidadDespacho = 0.0;
            this.total = 0.0;
        }

        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public double PrecioDia { get => precioDia; set => precioDia = value; }
        public double CantidadDespacho { get => cantidadDespacho; set => cantidadDespacho = value; }
        public double Total { get => total; set => total = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Bomba Bomba { get => bomba; set => bomba = value; }
        internal TipoDeDespacho TipoDeDespacho { get => tipoDeDespacho; set => tipoDeDespacho = value; }
        internal Despacho Siguiente { get => siguiente; set => siguiente = value; }
    }
}
