using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Bomba
    {
        private string codigoBomba;
        
        private string capacidadBomba;
        private string cantidadBomba;
      

        public Bomba() {

            this.codigoBomba = "";
            this.capacidadBomba = "";
            this.cantidadBomba = "";
         
        }



        public string CodigoBomba { get => codigoBomba; set => codigoBomba = value; }
   
        public string CapacidadBomba { get => capacidadBomba; set => capacidadBomba = value; }
        public string CantidadBomba { get => cantidadBomba; set => cantidadBomba = value; }

      
    }
}
