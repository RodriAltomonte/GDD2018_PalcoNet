using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Util;
using Classes.DatabaseConnection;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.Session;
/*
 * Esta funcionalidad permite a un cliente conocer todo su historial de compras.
Debe presentarse en una grilla paginada igual a la utilizada para la visualización de las
publicaciones. Se debe mostrar toda aquella información que se crea pertinente y el
medio de pago utilizado por el cliente al momento de efectuarse la compra.
 * */

namespace PalcoNet.HistorialCliente
{
    public partial class HistorialClienteForm : Form
    {
        private Form previousForm;
        int posicion = -1;
        string username;
        DataTable table = new DataTable();

        public HistorialClienteForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            username = Session.Instance().LoggedUsername;
            cargarResultados(1);
        }
        public HistorialClienteForm()
        {
            InitializeComponent();
            username = "10125617";
            cargarResultados(1);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void cargarResultados(int pagina)
        {
            if (pagina > 0 )
            {
                posicion = pagina;
                pagina--;
                int x = pagina * 5;
                string select = @"select fecha_compra 'Fecha de Compra',monto_total 'Monto Total',cantidad_ubicaciones 'Cantidad de Ubicaciones',tarjeta_comprador 'Medios de Pago' 
                                    from LOS_DE_GESTION.Compra where usuario_cliente_comprador = '" + username+ "' ";
                                   //@"' group by fecha_compra,tarjeta_comprador ";

                string final = @" ORDER BY fecha_compra 
                                OFFSET " + x.ToString() + @" ROWS FETCH NEXT " + 5 + " ROWS ONLY";

                select += final;
                 table = ConnectionFactory.Instance().CreateConnection().ExecuteDataTableSqlQuery(select);
                 if (table.Rows.Count > 0)
                 {
                     dgvResultados.DataSource = table;
                 }
                 else
                 {
                     posicion--;
                 }
            }

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            cargarResultados(posicion - 1);
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            cargarResultados(posicion + 1);
        }

   
    }
}
