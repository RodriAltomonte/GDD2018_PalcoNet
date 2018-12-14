using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Configuration;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class ClienteRepository
    {
        public void ValidarVencimientoDePuntosDeCliente(string username)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@clienteUsername", username)
                .AddParameter("@fechaHoy", ConfigurationManager.Instance().GetSystemDateTime());

            ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.ValidarVencimientoDePuntos, inputParameters);
        }

        public bool ClienteTieneTarjeta(string username)
        {
            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteSingleOutputStoredProcedure<bool>(SpNames.ClienteTieneTarjeta, StoredProcedureParameterMap.Of("@username", username), "@tieneTarjeta");
        }
    }
}
