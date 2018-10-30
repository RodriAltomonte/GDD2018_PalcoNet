using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Constants
{
    static class SpNames
    {
        private const string Schema = "LOS_DE_GESTION.";
        public const string ValidarLogin = Schema + "PR_Validar_login";
        public const string FuncionaliadesDeUnRol = Schema + "PR_FUNCIONALIDADES_DE_UN_ROL";
        public const string RolDeUsuario = Schema + "PR_ROL_DE_USUARIO";
        public const string AltaDeUsuario = Schema + "PR_ALTA_DE_USUARIO";
        public const string RolesClienteYEmpresa = Schema + "PR_ROLES_CLIENTE_Y_EMPRESA";
        public const string CambiarPassword = Schema + "PR_CAMBIAR_PASSWORD";
        public const string DarDeBajaUsuarioPorAdmin = Schema + "PR_DAR_BAJA_USUARIO_POR_ADMIN";
    }
}
