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
using PalcoNet.Classes.Model;
using System.Data;

namespace PalcoNet.Classes.Repository
{
    class UsuarioRepository
    {
        public Boolean ExisteUsuarioYContrasenia(string username, string contrasenia)
        {
            StoredProcedureParameterMap parameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username)
                .AddParameter("@password", contrasenia);
            
            return ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteSingleOutputStoredProcedure<Boolean>(SpNames.ValidarLogin, parameters, "@loginCorrecto");

        }

        public void AltaDeUsuario(Usuario usuario)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", usuario.Username)
                .AddParameter("@password", usuario.Password)
                .AddParameter("@idRol", usuario.IdRol);

            ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.AltaDeUsuario, inputParameters);
        }

        public void CambiarPassword(string username, string newPassword)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username)
                .AddParameter("@password", newPassword);

            ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.CambiarPassword, inputParameters);
        }

        public void DarDeBajaUnUsuarioPorAdmin(string username)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username);

            ConnectionFactory.Instance()
                .CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.DarDeBajaUsuarioPorAdmin, inputParameters);
        }

        public Boolean EsUsuarioMigrado(string username) 
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@username", username);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteSingleOutputStoredProcedure<Boolean>(SpNames.EsUsuarioMigrado, inputParameters, "@esMigrado");
        }

        public DataTable BuscarUsuarios(string filtroUsername)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap().AddParameter("@usernameFilter", filtroUsername);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.BuscarUsuarios, inputParameters);        
        }

    }
}
