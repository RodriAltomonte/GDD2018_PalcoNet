using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class UbicacionPersistente
    {        
        public decimal CodPublicacion { get; set; }
        public string Fila { get; set; }
        public int CantidadDeLugares { get; set; }
        public bool SinNumerar { get; set; }
        public string Precio { get; set; }
        public decimal IdTipoUbicacion { get; set; }
    }
}
