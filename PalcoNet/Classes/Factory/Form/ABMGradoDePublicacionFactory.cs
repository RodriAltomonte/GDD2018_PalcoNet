using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Factory.Form
{
    static class ABMGradoDePublicacionFactory
    {
        private const string ALTA = "Alta";
        private const string BAJA = "Baja";
        private const string MODIFICACION = "Modificacion";

        public static System.Windows.Forms.Form CrearForm(string abm, System.Windows.Forms.Form from)
        {
            switch (abm)
            {
                case ALTA:
                    return new ABMGrado.AltaGradoForm(from);
                case BAJA:
                    return new ABMGrado.BajaGradoForm(from);
                case MODIFICACION:
                    return new ABMGrado.ModificacionGradoForm(from);
                default:
                    return null; //This should never happen
            }
        }

    }
}
