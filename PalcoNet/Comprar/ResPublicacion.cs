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

namespace PalcoNet.Comprar
{
    public partial class ResPublicacion : Form
    {
        private const int PAGE_SIZE = 10;
        private Form previousForm;
        string descripcion;
        string fechaInicial;
        string fechaFinal;
        List<String> categorias;
        int posicion;

        public ResPublicacion(Form previousForm,List<String> categorias,string descripcion,string fechaInicial,string fechaFinal )
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.descripcion = descripcion;
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
            this.categorias = categorias;
         
            cargarResultados(1);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void ResultadoPublicacion_Load(object sender, EventArgs e)
        {
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            cargarResultados(posicion - 1);
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoPublicacion = dgvResultados.SelectedRows[0].Cells[0].Value.ToString();
                NavigableFormUtil.ForwardTo(this, new UbicacionesForm(this, codigoPublicacion));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBoxUtil.ShowError("Seleccione una fila válida.");
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            cargarResultados(posicion + 1);
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            cargarResultados(1);
        }

        #region Auxiliary methods
        private void cargarResultados(int pagina)
        {
            if (pagina > 0)
            {
                posicion = pagina;
                pagina--;
                int basePagina = pagina * PAGE_SIZE;
                string select = @"SELECT p.cod_publicacion AS Codigo,p.descripcion AS Descripcion,p.fecha_publicacion AS 'Fecha de publicacion'," +
                                    "p.fecha_vencimiento_publicacion AS 'Fecha de vencimiento',p.fecha_hora_espectaculo AS 'Fecha y hora de espectaculo'," +
                                    "p.direccion_espectaculo AS Direccion,p.usuario_empresa_vendedora AS 'Usuario empresa'" +
                                    "from LOS_DE_GESTION.Publicacion p join LOS_DE_GESTION.Rubro r on (p.id_Rubro = r.id_Rubro) ";

                string final = @"ORDER BY p.id_grado_publicacion,p.cod_publicacion ASC "+
                                "OFFSET " + basePagina.ToString() + @" ROWS FETCH NEXT " + PAGE_SIZE + " ROWS ONLY";
                if (categorias.Count != 0 || descripcion != "" || fechaInicial != "" || fechaFinal != "")
                {
                    select += "where p.id_estado_publicacion = 1 and ";

                    if (descripcion != "")
                    {
                        select += "p.descripcion = '" + descripcion + "' ";
                        select += " and ";
                    }

                    if (fechaInicial != "")
                    {
                        select += "p.fecha_publicacion >= '" + fechaInicial + "' ";
                        select += " and ";
                    }
                    if (fechaFinal != "")
                    {
                        select += "p.fecha_publicacion <= '" + fechaFinal + "' ";
                        select += " and ";
                    }
                    string rDescripcion = "r.descripcion = ";

                    foreach (var rubros in categorias)
                    {
                        select +=  rDescripcion ;
                        select += "'" + rubros + "'";
                        select += " or ";
                    }

                    if (categorias.Count > 0)
                    {
                        select = select.Substring(0, select.Length - 3);
                    }
                    else
                    {
                        select = select.Substring(0, select.Length - 4);
                    }
                }

                select += final;
                
              dgvResultados.DataSource = ConnectionFactory.Instance().CreateConnection().ExecuteDataTableSqlQuery(select);
            }
        }
        #endregion

        private void btnPrimera_Click(object sender, EventArgs e)
        {
            int primeraPagina = 1 ;
            cargarResultados(primeraPagina);
        }

        private void btnUltima_Click(object sender, EventArgs e)
        {
            int ultimaPagina = posicion;
            cargarResultados(ultimaPagina);
        }
    }
}
