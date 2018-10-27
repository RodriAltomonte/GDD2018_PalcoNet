using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PalcoNet.Classes.DatabaseConnection
{
    interface IStoredProcedureResultMapper<TResult>
    {
        IList<TResult> Map(DataTable dataTable);
    }
}
