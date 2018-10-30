using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Model;

namespace PalcoNet.Classes.Repository
{
    class RolRepository
    {
        public Rol IdRolDeUsuario(string username)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username);

            IList<Rol> roles =  ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteMappedStoredProcedure<Rol>(SpNames.RolDeUsuario, inputParameters, new Mapper.AutoMapper<Rol>());

            return roles.First<Rol>();
        }

        public IList<Rol> RolesDeClienteYEmpresa()
        {
            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteMappedStoredProcedure<Rol>(SpNames.RolesClienteYEmpresa, null, new Mapper.AutoMapper<Rol>());
        }
    }
}
