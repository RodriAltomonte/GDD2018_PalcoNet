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

        public static StoredProcedureParameterMap Of(string key, object value)
        {
            return new StoredProcedureParameterMap().AddParameter(key, value);
        }


        public StoredProcedureParameterMap(IDictionary<string, object> parametersMap)
        {
            this.parametersMap = parametersMap;
        }

        public StoredProcedureParameterMap AddParameter(string key, object value)
        {
            parametersMap.Add(key, value);
            return this;
        }

        public void RemoveParameters()
        {
            parametersMap.Clear();
            return;
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
