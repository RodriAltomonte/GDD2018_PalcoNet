using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PalcoNet.Classes.Repository;

namespace PalcoNet.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        #region ComboBox constants
        private const string EMPRESAS_LOCALIDADES_NO_VENDIDAS = "Empresa con mayor cantidad de localidades no vendidas";
        private const string CLIENTES_MAS_PUNTOS_VENCIDOS = "Clientes con mayores puntos vencidos";
        private const string CLIENTES_MAS_COMPRAS = "Clientes con mayor cantidad de compras";

        private const string PRIMER_TRIMESTRE = "Enero - Abril";
        private const string SEGUNDO_TRIMESTRE = "Mayo - Agosto";
        private const string TERCER_TRIMESTRE = "Septiembre - Diciembre";
        #endregion

        private ListadoEstadisticoRepository listadoEstadisticoRepository;

        public ListadoEstadisticoForm()
        {
            InitializeComponent();
            this.listadoEstadisticoRepository = new ListadoEstadisticoRepository();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarFiltros())
            {
                //TODO separar en clases
                switch (cmbTipoListado.SelectedItem.ToString())
                {
                    case EMPRESAS_LOCALIDADES_NO_VENDIDAS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.EmpresasConMasLocalidadesNoVendidas(DateTime.Now, DateTime.Now);
                        break;
                    case CLIENTES_MAS_COMPRAS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.ClientesConMasCompras(DateTime.Now, DateTime.Now);
                        break;
                    case CLIENTES_MAS_PUNTOS_VENCIDOS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.ClientesConMasPuntosVencidos(DateTime.Now, DateTime.Now);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Los filtros ingresados son inválidos.");
            }
        }

        #region Auxiliary methods
        private void ListadoEstadisticoForm_Load(object sender, EventArgs e)
        {
            cmbTipoListado.Items.Add(EMPRESAS_LOCALIDADES_NO_VENDIDAS);
            cmbTipoListado.Items.Add(CLIENTES_MAS_COMPRAS);
            cmbTipoListado.Items.Add(CLIENTES_MAS_COMPRAS);

            cmbTrimestre.Items.Add(PRIMER_TRIMESTRE);
            cmbTrimestre.Items.Add(SEGUNDO_TRIMESTRE);
            cmbTrimestre.Items.Add(TERCER_TRIMESTRE);
        }

        private Boolean ValidarFiltros()
        {
            Regex regexNumeros = new Regex("^[0-9]*$");
            return regexNumeros.IsMatch(txtAnio.Text) && cmbTipoListado.SelectedItem != null && cmbTrimestre.SelectedItem != null;
        }
        #endregion
    }
}
