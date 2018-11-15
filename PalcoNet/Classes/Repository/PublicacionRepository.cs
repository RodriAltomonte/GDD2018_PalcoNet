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
    class PublicacionRepository
    {
        public void CrearPublicacion(Publicacion publicacion) 
        { 
            //TODO
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();

            ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.CrearPublicacion, inputParameters);
        }
    }
}
