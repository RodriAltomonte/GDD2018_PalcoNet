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

namespace PalcoNet.Comprar
{
    public partial class ResPublicacion : Form
    {
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
            this.categorias = new List<String>();
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

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            cargarResultados(posicion + 1);
        }

        private void cargarResultados(int pagina)
        {
            if (pagina > 0)
            {
                posicion = pagina;
                pagina--;
                int x = pagina * 5;
                string select = @"SELECT p.descripcion,p.fecha_publicacion,
                                    p.fecha_vencimiento_publicacion,p.fecha_hora_espectaculo,
                                    p.direccion_espectaculo 
                                    from LOS_DE_GESTION.Publicacion p join LOS_DE_GESTION.Rubro r on (p.id_Rubro = r.id_Rubro ) ";

                string final = @"ORDER BY cod_publicacion
                                OFFSET " + x.ToString() + @" ROWS FETCH NEXT " + 5 + " ROWS ONLY";
                if (categorias.Count != 0 || descripcion != "" || fechaInicial != "" || fechaFinal != "")
                {
                    select += "where ";


                    if (descripcion != "")
                    {
                        select += "p.descripcion = " + descripcion + " ";
                        select += " and ";
                    }

                    if (fechaInicial != "")
                    {
                        select += "p.fecha_publicacion = '" + fechaInicial + "' ";
                        select += " and ";
                    }
                    if (fechaFinal != "")
                    {
                        select += "p.fecha_vencimiento_publicacion = '" + fechaFinal + "' ";
                        select += " and ";
                    }
                    string rDescripcion = "r.descripcion = ";

                    foreach (var rubros in categorias)
                    {
                        select += rDescripcion;
                        select += rubros;
                        select += " and ";
                    }

                    select = select.Substring(0, select.Length - 4);

                }

                select += final;
                
                ConnectionFactory.Instance().CreateConnection().ExecuteDataTableSqlQuery(select);
            }
        }
    }
}
