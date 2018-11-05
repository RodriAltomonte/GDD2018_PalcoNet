using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class PremioRepository
    {
        public IList<Premio> PremiosDisponibles()
        { 
            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteMappedStoredProcedure<Premio>(SpNames.PremiosDisponibles,null,new Mapper.AutoMapper<Premio>());
        }

        public void CanjearPremio(string username, decimal idPremio)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username)
                .AddParameter("@idPremio", idPremio);

            ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.CanjearPremio, inputParameters);
        }

        public PuntosDeUsuario PuntosDeUsuario(string username)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap().AddParameter("@username", username);

            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteMappedStoredProcedure(SpNames.PuntosDeUsuario, inputParameters, new Mapper.AutoMapper<PuntosDeUsuario>())
                .First();
        }

    }
}
