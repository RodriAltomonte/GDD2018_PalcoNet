using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PalcoNet.Classes.DatabaseConnection
{
    class StoredProcedureParameterMap
    {
        private IDictionary<string, object> parametersMap;

        public StoredProcedureParameterMap() 
        {
            parametersMap = new Dictionary<string, object>();
        }

        public StoredProcedureParameterMap(IDictionary<string, object> parametersMap)
        {
            this.parametersMap = parametersMap;
        }

        public void AddParameter(string key, object value)
        {
            parametersMap.Add(key, value);
        }

        public void AddParametersToCommand(SqlCommand command)
        {
            foreach (KeyValuePair<string, object> item in parametersMap)
            {
                command.Parameters.Add(item.Key, item.Value);
            }
        }

        
    }
}
