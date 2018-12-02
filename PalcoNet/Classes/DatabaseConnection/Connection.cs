using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;

namespace Classes.DatabaseConnection
{
    class Connection
    {
        private SqlConnection sqlConnection;
        
        public Connection(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }


        public void OpenConnection()
        {
            sqlConnection.Open();
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }

        public void TestConnection()
        {
            SqlCommand command = new SqlCommand("select 1", sqlConnection);
            OpenConnection();
            command.ExecuteReader();
            CloseConnection();
        }

        #region Stored procedure execution
        public TOutput ExecuteSingleOutputStoredProcedure<TOutput>(string procedureName, StoredProcedureParameterMap parameters, string outputParameterName)
        {
            using(sqlConnection)
            using(SqlCommand command = new SqlCommand(procedureName, sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                this.AddInputParametersToCommandIfTheyAreNotNull(parameters, command);
                command.Parameters.Add(outputParameterName, SqlDbTypes.Of(typeof(TOutput))).Direction = ParameterDirection.Output;

                OpenConnection();

                try
                {
                    command.ExecuteNonQuery();
                    return (TOutput)command.Parameters[outputParameterName].Value;
                }
                catch (SqlException e)
                {
                    throw new StoredProcedureException(e.Message, e);
                }
            }
        }

        public TOutput ExecuteSingleOutputSqlQuery<TOutput>(string query)
        {
            TOutput value ;
            using (sqlConnection)
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.CommandType = CommandType.Text;
                OpenConnection();

                try
                {
                   value=(TOutput) command.ExecuteScalar();
                    return value;
                }
                catch (SqlException e)
                {
                    throw new StoredProcedureException(e.Message, e);
                }
            }
        }




        public DataTable ExecuteDataTableStoredProcedure(string procedureName, StoredProcedureParameterMap inputParameters)
        {
            DataTable dataTable = new DataTable();
            using(sqlConnection)
            using(SqlCommand command = new SqlCommand(procedureName, sqlConnection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                this.AddInputParametersToCommandIfTheyAreNotNull(inputParameters, command);

                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new StoredProcedureException(e.Message, e);
                }
            }
            return dataTable;
        }

      

        public IList<TMapped> ExecuteMappedStoredProcedure<TMapped>(string procedureName, StoredProcedureParameterMap inputParameters, IStoredProcedureResultMapper<TMapped> mapper)
        {
            DataTable result = this.ExecuteDataTableStoredProcedure(procedureName, inputParameters);
            return mapper.Map(result);
        }
       
        #endregion


        public DataTable ExecuteDataTableSqlQuery(string sqlQuery)
        {
            DataTable dt = new DataTable();
            using (sqlConnection)
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                try
                {
                    da.Fill(dt);

                }
                catch (SqlException e)
                {
                    throw new SqlQueryException(e.Message, e);
                }
                return dt;
            }
        }

        public DataSet ExecuteDataSetSqlQuery(string sqlQuery,string row)
        {
            DataSet ds = new DataSet();
            using (sqlConnection)
            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                try
                {
                    da.Fill(ds,row);

                }
                catch (SqlException e)
                {
                    throw new SqlQueryException(e.Message, e);
                }
                return ds;
            }
        }



        #region Private methods
        private void AddInputParametersToCommandIfTheyAreNotNull(StoredProcedureParameterMap inputParameters, SqlCommand command)
        {
            if (inputParameters != null)
            {
                inputParameters.AddParametersToCommand(command);
            }
        }
        #endregion
    }

}
