using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.DatabaseConnection;
using PalcoNet.Classes.DatabaseConnection;
using System.Data.SqlClient;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class UsuarioRepository
    {
        public Boolean ExisteUsuarioYContrasenia(string username, string contrasenia)
        {
            StoredProcedureParameterMap parameters = new StoredProcedureParameterMap();
            parameters.AddParameter("@username", username);
            parameters.AddParameter("@password", contrasenia);

            try
            {
                return ConnectionFactory.Instance()
                    .CreateConnection()
                    .ExecuteStoredProcedureWithSingleOutput<Boolean>(SpNames.ValidarLogin, parameters, "@loginCorrecto");
            }
            catch (SqlException e)
            {
                throw new StoredProcedureException(e.Message);
            }
        }
    }
}
