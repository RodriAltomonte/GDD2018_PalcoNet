using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;

namespace PalcoNet.Classes.Repository.Mapper
{
    class UbicacionPersistenteDGVMapper : IStoredProcedureResultMapper<UbicacionPersistente>
    {
        public IList<UbicacionPersistente> Map(System.Data.DataTable dataTable)
        {
            IList<UbicacionPersistente> ubicaciones = new List<UbicacionPersistente>();

            foreach (System.Data.DataRow item in dataTable.Rows)
            {
                UbicacionPersistente ubicacion = new UbicacionPersistente();

                ubicacion.Fila = (string)item[0];
                ubicacion.CantidadDeLugares = (int)item[1];
                ubicacion.Precio = item[2].ToString();
                ubicacion.DescripcionTipoUbicacion = (string)item[3];
                ubicacion.IdTipoUbicacion = (decimal)item[4];
                ubicaciones.Add(ubicacion);
            }

            return ubicaciones;
        }
    }
}
