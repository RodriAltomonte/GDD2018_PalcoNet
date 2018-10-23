using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Util;
using Classes.Configuration.Exception;

namespace Classes.Configuration
{
    class ConfigurationManager
    {
        public enum Property { IP, INSTANCIA, BASE_DATOS, PUERTO, USUARIO_DB, CONTRASENIA, FECHA_HORA_SISTEMA};

        private const string IP = "IP";
        private const string INSTANCIA = "INSTANCIA_SQL";
        private const string BASE_DATOS = "BASE_DATOS";
        private const string USUARIO_DB = "USUARIO_DB";
        private const string CONTRASENIA = "CONTRASENIA";
        private const string FECHA_HORA_SISTEMA = "FECHA_HORA_SISTEMA";
        private const string PUERTO = "PUERTO";

        private static ConfigurationManager configuracion;
        private static readonly string RUTA_ARCHIVO_CONFIGURACION = "archivo_configuracion.txt";
        
        private IDictionary<Property, string> properties;

        private ConfigurationManager() 
        {
            string[] lines = System.IO.File.ReadAllLines(RUTA_ARCHIVO_CONFIGURACION);

            properties = new Dictionary<Property,string>();

            properties.Add(Property.IP, StringUtil.GetConfigValue(lines, IP));
            properties.Add(Property.INSTANCIA, StringUtil.GetConfigValue(lines, INSTANCIA));
            properties.Add(Property.BASE_DATOS, StringUtil.GetConfigValue(lines, BASE_DATOS));
            properties.Add(Property.USUARIO_DB, StringUtil.GetConfigValue(lines, USUARIO_DB));
            properties.Add(Property.CONTRASENIA, StringUtil.GetConfigValue(lines, CONTRASENIA));
            properties.Add(Property.FECHA_HORA_SISTEMA, StringUtil.GetConfigValue(lines, FECHA_HORA_SISTEMA));
            properties.Add(Property.PUERTO, StringUtil.GetConfigValue(lines, PUERTO));
        }

        public static ConfigurationManager Instance() 
        {
            if (configuracion == null)
            {
                configuracion = new ConfigurationManager();
            }
            return configuracion;
        }

        #region Public methods
        public string GetPropertyValue(Property property) 
        {
            if (!properties.ContainsKey(property))
            {
                throw new ConfigurationPropertyNotFoundException(property.ToString() + " property has not been found.");
            }
            return properties[property];
        }

        public DateTime GetSystemDateTime() 
        {
            return DateTime.ParseExact(GetPropertyValue(Property.FECHA_HORA_SISTEMA), "dd-MM-yyyy HH:mm", null);
        }

        public Boolean PropertyExists(Property property) 
        {
            return properties.ContainsKey(property);
        }
        #endregion
    }
}
