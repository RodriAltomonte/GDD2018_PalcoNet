using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class Compra
    {
        public decimal IdCompra { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaDeCompra { get; set; }
        public string UsuarioComprador { get; set; }
        public string TarjetaComprador { get; set; }
        public decimal CantidadUbicaciones { get; set; }
    }
}
