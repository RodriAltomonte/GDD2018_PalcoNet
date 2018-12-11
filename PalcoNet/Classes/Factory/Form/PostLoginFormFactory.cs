using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Factory.Form
{
    static class PostLoginFormFactory
    {
        private static IDictionary<decimal, Type> formMap;

        static PostLoginFormFactory() 
        {
            formMap = new Dictionary<decimal, Type>();

            formMap.Add(FuncionalidadConstants.ABMRol, typeof(ABMRol.AltaRol));
            formMap.Add(FuncionalidadConstants.RegistroUsuario, typeof(RegistroUsuario.RegistroDeUsuarioForm));
            formMap.Add(FuncionalidadConstants.ABMCliente, typeof(ABMCliente.AltaCliente));
            formMap.Add(FuncionalidadConstants.ABMEmpresaEspectaculos, typeof(ABMEmpresaEspectaculo.ABMClienteEmpresaFormFactory));
            formMap.Add(FuncionalidadConstants.ABMRubro, typeof(ABMRubro.ABMRubroForm));
            formMap.Add(FuncionalidadConstants.ABMGradoPublicacion, typeof(ABMGrado.ABMGradoPublicacionForm));
            formMap.Add(FuncionalidadConstants.GenerarPublicacion, typeof(GenerarPublicacion.GenerarPublicacionForm));
            formMap.Add(FuncionalidadConstants.EditarPublicacion, typeof(EditarPublicacion.EditarPublicacionForm));
            formMap.Add(FuncionalidadConstants.Comprar, typeof(Comprar.Comprar));
            formMap.Add(FuncionalidadConstants.HistorialCliente, typeof(HistorialCliente.HistorialClienteForm));
            formMap.Add(FuncionalidadConstants.GenerarRendicion, typeof(GenerarRendicionComisiones.GenerarRendicionForm));
            formMap.Add(FuncionalidadConstants.ListadoEstadistico, typeof(ListadoEstadistico.ListadoEstadisticoForm));
            formMap.Add(FuncionalidadConstants.ModificarPasswordEmpresa, typeof(RegistroUsuario.ModificarPasswordUsuarioForm));
            //formMap.Add(FuncionalidadConstants.BajaDeUsuario, typeof());
            formMap.Add(FuncionalidadConstants.CanjePuntos, typeof(CanjePuntos.CanjePuntosForm));

        }

        public static System.Windows.Forms.Form CreateForm(decimal selectedItemId, System.Windows.Forms.Form previousForm)
        {

            return (System.Windows.Forms.Form)Activator.CreateInstance(formMap[selectedItemId], previousForm);
        }

    }
}
