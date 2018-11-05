using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class PuntosDeUsuario
    {
        public string Username { get; set; }
        public int PuntosDisponibles { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
    }
}
