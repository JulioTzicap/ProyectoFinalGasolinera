using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ListaDespacho
    {
        private Despacho inicio;
        private Despacho final;

        public ListaDespacho()
        {
            this.inicio = null;
            this.final = null;
        }

        public Despacho Inicio { get => inicio; set => inicio = value; }
        public Despacho Final { get => final; set => final = value; }

        public void InsertarFinal(Despacho nuevoDespacho)
        {
            if (this.inicio == null)
            {
                InsertarPrimero(nuevoDespacho);
            }
            else
            {
                final.Siguiente = nuevoDespacho;
                final = nuevoDespacho;
                final.Siguiente = null;
            }
        }

        private void InsertarPrimero(Despacho nuevoDespacho)
        {
            this.inicio = nuevoDespacho;
            this.final = nuevoDespacho;
            final.Siguiente = null;
        }

        public void ActualizarArchivoDeTexto()
        {
            string nombreArchivo = "gasolinera.txt";
            using (FileStream archivo = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write))
            using (StreamWriter escribirArchivo = new StreamWriter(archivo))
            {
                escribirArchivo.WriteLine("Nombre;Apellido;NIT;Bomba;TipoDeDespacho;FechaHora;PrecioDia;CantidadDespacho;Total");
                Despacho actual = inicio;
                while (actual != null)
                {
                    string linea = $"{actual.Cliente.Nombre};{actual.Cliente.Apellido};{actual.Cliente.Nit};{actual.Bomba.CodigoBomba};{actual.TipoDeDespacho.NombreTipoDespacho};{actual.FechaHora};{actual.PrecioDia};{actual.CantidadDespacho};{actual.Total}";
                    escribirArchivo.WriteLine(linea);
                    actual = actual.Siguiente;
                }
            }
        }

        public List<Despacho> GeneraradorDeInformes(DateTime fecha)
        {
            List<Despacho> despachoDeDia = new List<Despacho>();
            Despacho actual = inicio;
            while (actual != null)
            {
                if(actual.FechaHora.Date == fecha.Date)
                {
                    despachoDeDia.Add(actual);
                }
                actual = actual.Siguiente;
            }
            return despachoDeDia;
        }
        public List<Despacho> TipoDespacho(string tipo)
        {
            List<Despacho> despachosFiltrados = new List<Despacho>();
            Despacho actual = inicio;
            while (actual != null)
            {
                if (actual.TipoDeDespacho.NombreTipoDespacho == tipo)
                {
                    despachosFiltrados.Add(actual);
                }
                actual = actual.Siguiente;
            }
            return despachosFiltrados;
        }
        public List<Despacho> BombaEleccion(string codigoBomba)
        {
            List<Despacho> despachosFiltrados = new List<Despacho>();
            Despacho actual = inicio; // Asumiendo que 'inicio' es el primer elemento de la lista enlazada de despachos.
            while (actual != null)
            {
                if (actual.Bomba.CodigoBomba == codigoBomba)
                {
                    despachosFiltrados.Add(actual);
                }
                actual = actual.Siguiente; // Asumiendo que 'Siguiente' apunta al siguiente Despacho en la lista.
            }
            return despachosFiltrados;
        }

        public Dictionary<string, int> ContarDespachosPorBomba()
        {
            Dictionary<string, int> contadorDespachos = new Dictionary<string, int>();
            Despacho actual = inicio; // Asumiendo que 'inicio' es el primer elemento de la lista enlazada de despachos.

            while (actual != null)
            {
                string codigoBomba = actual.Bomba.CodigoBomba;
                if (contadorDespachos.ContainsKey(codigoBomba))
                {
                    contadorDespachos[codigoBomba]++;
                }
                else
                {
                    contadorDespachos[codigoBomba] = 1;
                }
                actual = actual.Siguiente; // Asumiendo que 'Siguiente' apunta al siguiente Despacho en la lista.
            }

            return contadorDespachos;
        }

       



    }
}
