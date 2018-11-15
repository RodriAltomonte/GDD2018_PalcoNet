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
    class EstadoDePublicacionRepository
    {
        public IList<EstadoDePublicacion> TodosLosEstadosDePublicacion()
        {
            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteMappedStoredProcedure(SpNames.TodosLosEstados, null, new Mapper.AutoMapper<EstadoDePublicacion>());
        }
    }
}
