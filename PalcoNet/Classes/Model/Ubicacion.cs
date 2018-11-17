using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class Ubicacion
    {
        public decimal IdUbicacion { get; set; }
        public decimal CodPublicacion { get; set; }
        public string Fila { get; set; }
        public decimal Asiento { get; set; }
        public bool SinNumerar { get; set; }
        public decimal Precio { get; set; }
        public decimal IdTipoUbicacion { get; set; }
    }
}
