using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Classes.Repository;
using PalcoNet.Classes.Util;
using PalcoNet.Classes.Util.Form;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Factory;

namespace PalcoNet.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        #region ComboBox constants
        private const string EMPRESAS_LOCALIDADES_NO_VENDIDAS = "Empresa con mayor cantidad de localidades no vendidas";
        private const string CLIENTES_MAS_PUNTOS_VENCIDOS = "Clientes con mayores puntos vencidos";
        private const string CLIENTES_MAS_COMPRAS = "Clientes con mayor cantidad de compras";

        private const string PRIMER_TRIMESTRE = "Enero - Marzo";
        private const string SEGUNDO_TRIMESTRE = "Abril - Junio";
        private const string TERCER_TRIMESTRE = "Julio - Septiembre";
        private const string CUARTO_TRIMESTRE = "Octubre - Diciembre";
        #endregion

        private ListadoEstadisticoRepository listadoEstadisticoRepository;
        private Form callerForm;

        public ListadoEstadisticoForm(Form callerForm)
        {
            InitializeComponent();
            this.listadoEstadisticoRepository = new ListadoEstadisticoRepository();
            this.callerForm = callerForm;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarFiltros())
            {
                //TODO separar en clases
                switch (cmbTipoListado.SelectedItem.ToString())
                {
                    case EMPRESAS_LOCALIDADES_NO_VENDIDAS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.EmpresasConMasLocalidadesNoVendidas(Quarter().Desde, Quarter().Hasta);
                        break;
                    case CLIENTES_MAS_COMPRAS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.ClientesConMasCompras(Quarter().Desde, Quarter().Hasta);
                        break;
                    case CLIENTES_MAS_PUNTOS_VENCIDOS:
                        dgvResultados.DataSource = listadoEstadisticoRepository.ClientesConMasPuntosVencidos(Quarter().Desde, Quarter().Hasta);
                        break;
                }
            }
            else
            {
                MessageBoxUtil.ShowError("Los filtros ingresados son inválidos.");
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
            cmbTrimestre.Items.Add(CUARTO_TRIMESTRE);
        }

        private Trimestre Quarter() 
        {
            switch (cmbTrimestre.SelectedItem.ToString())
            {
                case PRIMER_TRIMESTRE:
                    return QuarterFactory.FirstQuarterOf(int.Parse(txtAnio.Text));
                case SEGUNDO_TRIMESTRE:
                    return QuarterFactory.SecondQuarterOf(int.Parse(txtAnio.Text));
                case TERCER_TRIMESTRE:
                    return QuarterFactory.ThirdQuarterOf(int.Parse(txtAnio.Text));
                case CUARTO_TRIMESTRE:
                    return QuarterFactory.FourthQuarterOf(int.Parse(txtAnio.Text));
                default:
                    return null;
            }
        }

        private Boolean ValidarFiltros()
        {
           return RegexUtil.NumbersOnly(txtAnio.Text) && cmbTipoListado.SelectedItem != null && cmbTrimestre.SelectedItem != null;
        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, callerForm);
        }
    }
}
