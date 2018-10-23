using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Configuration;

namespace Classes.DatabaseConnection
{
    class ConnectionFactory
    {
        private static ConfigurationManager configuration = ConfigurationManager.Instance();
        private static ConnectionFactory conexionFactory;

        private ConnectionFactory() { }

        public static ConnectionFactory Instance() 
        {
            if (conexionFactory == null)
            {
                conexionFactory = new ConnectionFactory();
            }

            return conexionFactory;
        }

        public Connection CreateConnection() 
        {
            return new Connection(CreateConnectionString());
        }

        private string CreateConnectionString()
        {
            return "Data Source="
                + configuration.GetPropertyValue(ConfigurationManager.Property.IP)
                + "\\" + configuration.GetPropertyValue(ConfigurationManager.Property.INSTANCIA)
                + ";Initial Catalog=" + configuration.GetPropertyValue(ConfigurationManager.Property.BASE_DATOS)
                + ";User ID=" + configuration.GetPropertyValue(ConfigurationManager.Property.USUARIO_DB)
                + ";Password=" + configuration.GetPropertyValue(ConfigurationManager.Property.CONTRASENIA);
        }
    }
}
