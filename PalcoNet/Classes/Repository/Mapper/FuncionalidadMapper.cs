using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
using System.Data;

namespace PalcoNet.Classes.Repository.Mapper
{
    class FuncionalidadMapper : IStoredProcedureResultMapper<Funcionalidad>
    {
        public IList<Funcionalidad> Map(DataTable dataTable)
        {
            IList<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            foreach (DataRow row in dataTable.Rows)
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.Id = (decimal)row[0];
                funcionalidad.Descripcion = (string)row[1];

                funcionalidades.Add(funcionalidad);
            }

            return funcionalidades;
        }
    }
}
