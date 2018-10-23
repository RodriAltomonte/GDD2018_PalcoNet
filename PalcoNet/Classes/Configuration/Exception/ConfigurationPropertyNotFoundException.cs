using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Configuration.Exception
{
    public class ConfigurationPropertyNotFoundException : System.Exception
    {
        public ConfigurationPropertyNotFoundException(string message) : base(message) { }
    }
}
