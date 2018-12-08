using Classes.DatabaseConnection;
using PalcoNet.Classes.Constants;
using PalcoNet.Classes.CustomException;
using PalcoNet.Classes.DatabaseConnection;
using PalcoNet.Classes.Model;
using PalcoNet.Classes.Util;
using PalcoNet.Classes.Util.Form;
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
using Classes.Configuration;

namespace PalcoNet.Comprar
{
    public partial class Comprar : Form
    {
        private Form previousForm;
        private RubroRepository rubroRepository;

        public Comprar()
        {
              InitializeComponent();
              inicializarPantalla();
        }

        public Comprar(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            inicializarPantalla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void ComprarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

      
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            LbCategoria.Items.Clear();
            cmbCategoria.SelectedIndex = 0;
            cmbCategoria.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                List<String> categorias = new List<String>();
                foreach (var cat in LbCategoria.Items)
                {
                    categorias.Add(cat.ToString());
                }
                ResPublicacion publicacion = new ResPublicacion(this, categorias, txtDescripcion.Text, DateTimeUtil.Of(dtpFechaInicial.Value, dtpHoraInicial.Value).ToString("yyyy-MM-dd HH:mm:ss"), DateTimeUtil.Of(dtpFechaFinal.Value, dtpHoraFinal.Value).ToString("yyyy-MM-dd HH:mm:ss"));
                publicacion.Show();                 
                
                
            }
            catch (StoredProcedureException)
            {
                MessageBoxUtil.ShowError("Error al generar la publicacion.");
            }
          

        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
           LbCategoria.Items.Remove(LbCategoria.SelectedItem);
        }

        private void LbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbCategoria.Text != "" &&  !LbCategoria.Items.Contains(cmbCategoria.Text))
            LbCategoria.Items.Add(cmbCategoria.Text) ;
        }
    #region inicializar
        private void inicializarPantalla()
        {
            rubroRepository = new RubroRepository();
            ComboBoxFiller<Rubro, decimal>.Fill(cmbCategoria)
                .KeyAs(rubro => rubro.IdRubro)
                .ValueAs(rubro => rubro.Descripcion)
                .With(rubroRepository.TodosLosRubros());

            cmbCategoria.SelectedIndex = 0;
           dtpFechaInicial.Value =ConfigurationManager.Instance().GetSystemDateTime();
           dtpFechaFinal.Value = ConfigurationManager.Instance().GetSystemDateTime();
           dtpHoraFinal.Value = ConfigurationManager.Instance().GetSystemDateTime();
           dtpHoraInicial.Value = ConfigurationManager.Instance().GetSystemDateTime();

        }
    #endregion



    }
}
