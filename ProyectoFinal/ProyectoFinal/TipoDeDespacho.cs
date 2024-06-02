using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class TipoDeDespacho
    {
       
        private string nombreTipoDespacho;
       

        public TipoDeDespacho() 
        { 
           
            this.nombreTipoDespacho = string.Empty;
            
        }

     
        public string NombreTipoDespacho { get => nombreTipoDespacho; set => nombreTipoDespacho = value; }
      
    }
}
