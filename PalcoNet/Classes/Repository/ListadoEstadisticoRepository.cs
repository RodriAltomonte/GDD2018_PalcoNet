using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
using Classes.Configuration;
using System.Data;

namespace PalcoNet.Classes.Repository
{
    class ListadoEstadisticoRepository
    {
        public DataTable ClientesConMasCompras(DateTime fechaDesde, DateTime fechaHasta)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@fechaDesde", fechaDesde)
                .AddParameter("@fechaHasta", fechaHasta);

            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.ClientesConMasCompras, inputParameters);
        }

        public DataTable ClientesConMasPuntosVencidos(DateTime fechaDesde, DateTime fechaHasta)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@fechaDesde", fechaDesde)
                .AddParameter("@fechaHasta", fechaHasta);

            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.ClientesConMasPuntosVencidos, inputParameters);
        }

        public DataTable EmpresasConMasLocalidadesNoVendidas(DateTime fechaDesde, DateTime fechaHasta)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@fechaDesde", fechaDesde)
                .AddParameter("@fechaHasta", fechaHasta)
                .AddParameter("@fechaHoy", ConfigurationManager.Instance().GetSystemDateTime());

            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.EmpresasConMasLocalidadesNoVendidas, inputParameters);
        }
    }
}
