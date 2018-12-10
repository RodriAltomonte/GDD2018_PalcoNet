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

        public Publicacion Clone() 
        {
            Publicacion clonedPublicacion = new Publicacion();

            clonedPublicacion.CodPublicacion = this.CodPublicacion;
            clonedPublicacion.Descripcion = this.Descripcion;
            clonedPublicacion.FechaDePublicacion = this.FechaDePublicacion;
            clonedPublicacion.FechaDeVencimiento = this.FechaDeVencimiento;
            clonedPublicacion.FechaHoraDeEspectaculo = this.FechaHoraDeEspectaculo;
            clonedPublicacion.IdRubro = this.IdRubro;
            clonedPublicacion.DireccionEspectaculo = this.DireccionEspectaculo;
            clonedPublicacion.IdGradoDePublicacion = this.IdGradoDePublicacion;
            clonedPublicacion.UsuarioEmpresa = this.UsuarioEmpresa;
            clonedPublicacion.IdEstado = this.IdEstado;

            return clonedPublicacion;
        }
    }
}
