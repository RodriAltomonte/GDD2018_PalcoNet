using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class Publicacion
    {
        public decimal CodPublicacion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaHoraDeEspectaculo { get; set; }
        public decimal IdRubro { get; set; }
        public string DireccionEspectaculo { get; set; }
        public decimal IdGradoDePublicacion { get; set; }
        public string UsuarioEmpresa { get; set; }
        public decimal IdEstado { get; set; }
    }
}
