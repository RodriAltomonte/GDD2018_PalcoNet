﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class UbicacionRepository
    {
        public void CrearUbicaciones(UbicacionPersistente ubicacion)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@codPublicacion", ubicacion.CodPublicacion)
                .AddParameter("@fila", ubicacion.Fila)
                .AddParameter("@sinNumerar", ubicacion.SinNumerar)
                .AddParameter("@cantidad", ubicacion.CantidadDeLugares)
                .AddParameter("@precio", ubicacion.Precio)
                .AddParameter("@idTipoUbicacion", ubicacion.IdTipoUbicacion);

            ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.CrearUbicaciones, inputParameters);
        }

        public void InsertarListaDeUbicaciones(IList<UbicacionPersistente> ubicaciones) 
        {
            ubicaciones.ToList().ForEach(ubicacion => this.CrearUbicaciones(ubicacion));
        }

        public IList<UbicacionPersistente> UbicacionesEditables(decimal codPublicacion)
        {
            StoredProcedureParameterMap inputParameters = StoredProcedureParameterMap.Of("@codPublicacion", codPublicacion);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteMappedStoredProcedure<UbicacionPersistente>(
                SpNames.UbicacionesEditables, inputParameters, new Mapper.UbicacionPersistenteDGVMapper());
        }

        public void EliminarUbicaciones(IList<UbicacionPersistente> ubicaciones)
        {
            ubicaciones.ToList().ForEach(ubicacion => this.EliminarUbicacion(ubicacion));
        }

        public void EliminarUbicacion(UbicacionPersistente ubicacion) 
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@codPublicacion", ubicacion.CodPublicacion)
                .AddParameter("@fila", ubicacion.Fila)
                .AddParameter("@sinNumerar", ubicacion.SinNumerar)
                .AddParameter("@precio", ubicacion.Precio)
                .AddParameter("@idTipoUbicacion", ubicacion.IdTipoUbicacion);

            ConnectionFactory.Instance().CreateConnection()
                .ExecuteDataTableStoredProcedure(SpNames.EliminarUbicaciones, inputParameters);
        }
    }
}
