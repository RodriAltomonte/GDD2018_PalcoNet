using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    class Empresa : Usuario
    {
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Mail { get; set; }
        public decimal Telefono { get; set; }
        public string DireccionCalle { get; set; }
        public decimal DireccionNumero { get; set; }
        public decimal NroPiso { get; set; }
        public string Depto { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaDeCreacion { get; set; }
    }
}
