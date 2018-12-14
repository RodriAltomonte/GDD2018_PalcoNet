using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.DatabaseConnection;
using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;

namespace PalcoNet.Classes.Repository
{
    class CompraRepository
    {
        public decimal GenerarCompra(Compra compra, int puntosGanados)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap()
                .AddParameter("@fechaCompra", compra.FechaDeCompra)
                .AddParameter("@usuarioComprador", compra.UsuarioComprador)
                .AddParameter("@cantidadUbicaciones", compra.CantidadUbicaciones)
                .AddParameter("@montoTotal", compra.MontoTotal)
                .AddParameter("@tarjetaComprador", compra.TarjetaComprador)
                .AddParameter("@puntosGanados", puntosGanados);

            return ConnectionFactory.Instance().CreateConnection()
                .ExecuteSingleOutputStoredProcedure<decimal>(SpNames.GenerarCompra, inputParameters, "@idCompra");
        }
    }
}
