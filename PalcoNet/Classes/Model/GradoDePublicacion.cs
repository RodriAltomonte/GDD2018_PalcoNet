using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    public class GradoDePublicacion
    {
        public decimal IdGradoDePublicacion { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }

        public GradoDePublicacion() { }
        
        public GradoDePublicacion(decimal id, string descripcion, decimal porcentaje)
        {
            this.IdGradoDePublicacion = id;
            this.Descripcion = descripcion;
            this.Porcentaje = porcentaje;
        }

    }
}
