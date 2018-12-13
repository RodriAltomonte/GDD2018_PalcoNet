using Classes.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Comprar
{
    public partial class UbicacionesForm : Form
    {
        private string CodPublicacion;
        public UbicacionesForm(string codigo_publicacion)
        {
            InitializeComponent();
            InitializeForm();
            CodPublicacion = codigo_publicacion;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Crear nueva compra
            //actualizar las ubicaciones id_compra
            MessageBox.Show("Falta implementar");
        }

        #region Initialization
        private void InitializeForm()
        {
            dgvUbicaciones.DataSource = ConnectionFactory.Instance()
                                                         .CreateConnection()
                                                         .ExecuteDataTableSqlQuery(@"SELECT u.fila,u.asiento,u.precio FROM LOS_DE_GESTION.Ubicacion u 
                                                                                     JOIN LOS_DE_GESTION.Publicacion p 
                                                                                      ON u.cod_publicacion=p.cod_publicacion ");
        }
        #endregion
    }
}
