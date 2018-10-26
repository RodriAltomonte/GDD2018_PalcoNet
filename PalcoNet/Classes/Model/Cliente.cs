using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    class Cliente : Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public decimal NumeroDocumento { get; set; }
        public string CUIL { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string DireccionCalle { get; set; }
        public decimal DireccionNumero { get; set; }
        public decimal NroPiso { get; set; }
        public string Depto { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public string Tarjeta { get; set; }
        public Int32 PuntosAcumuladosValidos { get; set; }
        public Int32 PuntosVencidos { get; set; }
        public DateTime FechaDeVencimientoDePuntos { get; set; }
    }
}
