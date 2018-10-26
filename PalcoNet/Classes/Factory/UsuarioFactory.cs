using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.Model;

namespace PalcoNet.Classes.Factory
{
    static class UsuarioFactory
    {
        private static IDictionary<decimal, Type> usuariosPorRol;

        static UsuarioFactory() 
        { 
            usuariosPorRol = new Dictionary<decimal,Type>();
            usuariosPorRol.Add(RolConstants.Cliente, typeof(Cliente));
            usuariosPorRol.Add(RolConstants.Empresa, typeof(Empresa));
        }

        public static Classes.Model.Usuario CrearUsuario(decimal idRol) 
        {
            Type usuarioType = usuariosPorRol[idRol];
            return (Usuario)Activator.CreateInstance(usuarioType);
        }
    }
}
