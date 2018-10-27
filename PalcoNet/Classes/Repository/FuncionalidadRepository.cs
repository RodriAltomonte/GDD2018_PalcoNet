using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using Classes.DatabaseConnection;
using System.Data;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;

namespace PalcoNet.Classes.Repository
{
    class FuncionalidadRepository
    {
        public IList<Funcionalidad> FuncionalidadesDeUnRol(decimal idRol) 
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@idRol", idRol);
            try
            {
                return ConnectionFactory.Instance()
                    .CreateConnection()
                    .ExecuteMappedStoredProcedure<Funcionalidad>(SpNames.FuncionaliadesDeUnRol, inputParameters, new Mapper.AutoMapper<Funcionalidad>());
            }
            catch (AutoMappingException e)
            {
                throw new StoredProcedureException("Error al obtener funcionalidades del rol solicitado.", e);
            }

        }
    }
}
