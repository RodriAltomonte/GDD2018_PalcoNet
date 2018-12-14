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
    class GradoDePublicacionRepository
    {
        public IList<GradoDePublicacion> TodosLosGradosDePublicacion()
        {
            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteMappedStoredProcedure(SpNames.TodosLosGrados, null, new Mapper.AutoMapper<GradoDePublicacion>());
        }

        public void CrearGradoDePublicacion(GradoDePublicacion grado)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@idGrado", grado.IdGradoDePublicacion)
                .AddParameter("@descripcion", grado.Descripcion)
                .AddParameter("@porcentaje", grado.Porcentaje);

            ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.CrearGradoPublicacion, inputParameters);
        }


    }
}
