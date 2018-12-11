using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using System.Data;

namespace PalcoNet.Classes.Repository
{
    class PublicacionRepository
    {
        public decimal CrearPublicacion(Publicacion publicacion) 
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@descripcion", publicacion.Descripcion)
                .AddParameter("@fechaDePublicacion", publicacion.FechaDePublicacion)
                .AddParameter("@fechaVencimiento", publicacion.FechaDeVencimiento)
                .AddParameter("@fechaHoraEspectaculo", publicacion.FechaHoraDeEspectaculo)
                .AddParameter("@idRubro", publicacion.IdRubro)
                .AddParameter("@direccion", publicacion.DireccionEspectaculo)
                .AddParameter("@idGradoPublicacion", publicacion.IdGradoDePublicacion)
                .AddParameter("@usuarioEmpresa", publicacion.UsuarioEmpresa)
                .AddParameter("@idEstadoPublicacion", publicacion.IdEstado);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteSingleOutputStoredProcedure<decimal>(SpNames.CrearPublicacion, inputParameters, "@codPublicacionNueva");
        }

        public DataTable BuscarPublicacionesEditables(string usernameEmpresa, string descripcionPublicacion)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@usernameEmpresa", usernameEmpresa)
                .AddParameter("@descripcion", descripcionPublicacion);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.PublicacionesAEditar, inputParameters);
        }

        public Boolean ExisteUnaPublicacionIgual(Publicacion publicacion)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@codPublicacion", publicacion.CodPublicacion)
                .AddParameter("@descripcion", publicacion.Descripcion)
                .AddParameter("@fechaHoraEspectaculo", publicacion.FechaHoraDeEspectaculo)
                .AddParameter("@idRubro", publicacion.IdRubro)
                .AddParameter("@direccion", publicacion.DireccionEspectaculo);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteSingleOutputStoredProcedure<Boolean>(SpNames.ExisteUnaPublicacionIgual, inputParameters, "@existePublicacionIgual");
        }

        public void ActualizarPublicacion(Publicacion publicacion)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@codPublicacion", publicacion.CodPublicacion)
                .AddParameter("@descripcion", publicacion.Descripcion)
                .AddParameter("@fechaPublicacion", publicacion.FechaDePublicacion)
                .AddParameter("@fechaVencimientoPublicacion", publicacion.FechaDeVencimiento)
                .AddParameter("@fechaHoraEspectaculo", publicacion.FechaHoraDeEspectaculo)
                .AddParameter("@idRubro", publicacion.IdRubro)
                .AddParameter("@direccion", publicacion.DireccionEspectaculo)
                .AddParameter("@idGradoPublicacion", publicacion.IdGradoDePublicacion)
                .AddParameter("@idEstadoPublicacion", publicacion.IdEstado);


            ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.ActualizarPublicacion, inputParameters);
        }

        public Publicacion BuscarPorId(decimal idPublicacion)
        {
            StoredProcedureParameterMap inputParameters = StoredProcedureParameterMap.Of("@idPublicacion", idPublicacion);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteMappedStoredProcedure<Publicacion>(SpNames.BuscarPublicacionPorId, inputParameters, new Mapper.AutoMapper<Publicacion>())
                .First();
        }
    }
}
