using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.DatabaseConnection;
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
using Classes.Configuration;

namespace PalcoNet.GenerarRendicionComisiones
{
    /// <summary>
    /// Cuando el cliente hace una compra para una publicacion se debe crear una rendicion de esa compra
    /// rellenando los campos necesarios
    /// </summary>

    public partial class GenerarRendicionForm : Form
    {
        private Form previousForm;

        public GenerarRendicionForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.InicializarForm();
           }

        public GenerarRendicionForm()
        {
            InitializeComponent();
            this.InicializarForm();

        }

        private void InicializarForm()
        {
            CbCantidad.Items.Add(10);
            CbCantidad.Items.Add(20);
            CbCantidad.Items.Add(30);
            CbCantidad.Items.Add(40);
            CbCantidad.Items.Add(50);
            //CbCantidad.SelectedIndex = 0;
            DataSet ds = ConnectionFactory.Instance()
                        .CreateConnection()
                        .ExecuteDataSetSqlQuery("SELECT razon_social FROM LOS_DE_GESTION.Empresa", "razon_social");

              cbEmpresas.DisplayMember = "razon_social";
              cbEmpresas.DataSource = ds.Tables["razon_social"];
      

        
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (cbEmpresas.Text != " " && cbEmpresas.Text != " " && dgvCompras.Rows.Count > 0 )
            {

                decimal TotalImpVenta = 0;
                decimal TotalimpComi = 0;
                decimal TotalimpRendi = 0;
               
                string select =@"SELECT TOP 1 g.porcentaje_costo
	                            FROM LOS_DE_GESTION.Compra c 
	                            JOIN LOS_DE_GESTION.Ubicacion u ON c.id_Compra = u.id_Compra
	                            JOIN LOS_DE_GESTION.Publicacion p ON u.cod_publicacion=p.cod_publicacion
	                            join LOS_DE_GESTION.Grado_Publicacion g on ( g.id_Grado_Publicacion =p.id_Grado_Publicacion)
	                            WHERE c.id_Compra = ";

                decimal idRendicion= CrearRendicion();

                foreach (DataGridViewRow x in dgvCompras.Rows)
                {
                  decimal idCompra =  (decimal)x.Cells[0].Value;
                  decimal monto = (decimal)x.Cells[1].Value;
                  decimal Ubicaciones = (decimal)x.Cells[3].Value;

                  decimal porcentaje = ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputSqlQuery<decimal>(select + idCompra);
                  decimal imporComision = monto * porcentaje/100;
                  decimal imporRendicion = monto-imporComision;

                  TotalImpVenta += monto;
                  TotalimpComi += imporComision;
                  TotalimpRendi += imporRendicion;

                  CrearItemRendicion(idRendicion,monto,imporComision,imporRendicion, Ubicaciones,idCompra);
                 }
                ActualizarRendicion(idRendicion, TotalImpVenta, TotalimpComi, TotalimpRendi);
            }

        }

        private decimal CrearRendicion()
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@fecha_rendicion", ConfigurationManager.Instance().GetSystemDateTime());
            inputParameters.AddParameter("@razon_social", cbEmpresas.Text );
           return ConnectionFactory.Instance().CreateConnection().ExecuteSingleOutputStoredProcedure<decimal>(SpNames.CrearRendicion, inputParameters, "@idRendicion");

             
        }

        private void CrearItemRendicion(decimal idRendicion,decimal impVenta,decimal impComi,decimal impRendic,decimal cantUbicaciones,decimal idCompra)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
             inputParameters.AddParameter("@id_Rendicion",idRendicion);
             inputParameters.AddParameter("@importe_venta",impVenta);
             inputParameters.AddParameter("@importe_comision",impComi);
             inputParameters.AddParameter("@importe_rendicion",impRendic);
             inputParameters.AddParameter("@descripcion", "Comision por compra n " + idCompra);
             inputParameters.AddParameter("@cantidad_ubicaciones", cantUbicaciones);
             inputParameters.AddParameter("@id_Compra",idCompra);
            
            ConnectionFactory.Instance().CreateConnection().ExecuteDataTableStoredProcedure(SpNames.CrearItemRendicion, inputParameters);

        }

        private void CbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            traerCompras();
        }

        private void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            traerCompras();
        }

        private void traerCompras()
        {
            if (cbEmpresas.Text != "" && CbCantidad.Text != "")
            {
                //Obtengo las compras que se le realizaron a la empresa
                StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
                inputParameters.AddParameter("@razon_social", cbEmpresas.Text);
                inputParameters.AddParameter("@cantidad", CbCantidad.Text);
                dgvCompras.DataSource = ConnectionFactory.Instance()
                                                          .CreateConnection()
                                                          .ExecuteDataTableStoredProcedure(SpNames.ListadoComprasDeunaEmpresa, inputParameters);
            }
        }

        private void ActualizarRendicion(decimal idRendicion, decimal TotalImpVenta, decimal TotalimpComi, decimal TotalimpRendi)
        {
            StoredProcedureParameterMap inputParameters = new StoredProcedureParameterMap();
            inputParameters.AddParameter("@razon_social", idRendicion);
            inputParameters.AddParameter("", TotalImpVenta);
            inputParameters.AddParameter("", TotalimpComi);
            inputParameters.AddParameter("", TotalimpRendi);

            dgvCompras.DataSource = ConnectionFactory.Instance()
                                                      .CreateConnection()
                                                      .ExecuteDataTableStoredProcedure(SpNames.ActualizarRendicion, inputParameters);
      
        }
    }
}
