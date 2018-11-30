using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Factory.Form
{
    static class ABMClienteEmpresaFormFactory
    {
        private static IDictionary<decimal, Type> tiposDeFormPorRol;

        static ABMClienteEmpresaFormFactory()
        { 
            tiposDeFormPorRol = new Dictionary<decimal,Type>();
            tiposDeFormPorRol.Add(RolConstants.Cliente, typeof(ABMCliente.AltaCliente));
            tiposDeFormPorRol.Add(RolConstants.Empresa, typeof(ABMEmpresaEspectaculo.ABMEmpresaEspectaculoForm));
        }
        public static System.Windows.Forms.Form CrearForm(decimal idRol)
        {
            Type tipoForm = tiposDeFormPorRol[idRol];
            return (System.Windows.Forms.Form)Activator.CreateInstance(tipoForm);
        }

    }
}
