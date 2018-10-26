using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Model
{
    class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal IdRol { get; set; }
        public Int32 IntentosLogin { get; set; }
        public Boolean BloqueadoPorLoginFallidos { get; set; }
        public Boolean Habilitado { get; set; }
    }
}
