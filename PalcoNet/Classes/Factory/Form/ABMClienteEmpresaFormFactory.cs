﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.Model;

namespace PalcoNet.Classes.Factory.Form
{
    static class ABMClienteEmpresaFormFactory
    {
        private static IDictionary<decimal, Type> tiposDeFormPorRol;

        static ABMClienteEmpresaFormFactory()
        { 
            tiposDeFormPorRol = new Dictionary<decimal,Type>();
            tiposDeFormPorRol.Add(RolConstants.Cliente, typeof(ABMCliente.AltaCliente));
            tiposDeFormPorRol.Add(RolConstants.Empresa, typeof(ABMEmpresaEspectaculo.AltaEmpresa));
        }
        public static System.Windows.Forms.Form CrearForm(decimal idRol, System.Windows.Forms.Form callerForm ,Usuario usuario)
        {
            Type tipoForm = tiposDeFormPorRol[idRol];
            return (System.Windows.Forms.Form)Activator.CreateInstance(tipoForm, CrearParametros(callerForm, usuario));
        }

        private static object[] CrearParametros(System.Windows.Forms.Form form, Usuario usuario)
        {
            object[] parametros = new object[2];
            parametros[0] = form;
            parametros[1] = usuario;
            return parametros;
        }
    }
}
