namespace PalcoNet.ListadoEstadistico
{
    partial class ListadoEstadisticoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbTipoListado = new System.Windows.Forms.ComboBox();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblTipoListado = new System.Windows.Forms.Label();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpBusqueda.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.txtAnio);
            this.grpBusqueda.Controls.Add(this.cmbTrimestre);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.cmbTipoListado);
            this.grpBusqueda.Controls.Add(this.lblTrimestre);
            this.grpBusqueda.Controls.Add(this.lblAnio);
            this.grpBusqueda.Controls.Add(this.lblTipoListado);
            this.grpBusqueda.Location = new System.Drawing.Point(16, 30);
            this.grpBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBusqueda.Size = new System.Drawing.Size(672, 172);
            this.grpBusqueda.TabIndex = 0;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Filtros de Búsqueda";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(171, 76);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(132, 22);
            this.txtAnio.TabIndex = 6;
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(408, 76);
            this.cmbTrimestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(213, 24);
            this.cmbTrimestre.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(523, 123);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbTipoListado
            // 
            this.cmbTipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoListado.FormattingEnabled = true;
            this.cmbTipoListado.Location = new System.Drawing.Point(171, 41);
            this.cmbTipoListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoListado.Name = "cmbTipoListado";
            this.cmbTipoListado.Size = new System.Drawing.Size(451, 24);
            this.cmbTipoListado.TabIndex = 3;
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(333, 80);
            this.lblTrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(68, 17);
            this.lblTrimestre.TabIndex = 2;
            this.lblTrimestre.Text = "Trimestre";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(48, 80);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 17);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año";
            // 
            // lblTipoListado
            // 
            this.lblTipoListado.AutoSize = true;
            this.lblTipoListado.Location = new System.Drawing.Point(48, 44);
            this.lblTipoListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoListado.Name = "lblTipoListado";
            this.lblTipoListado.Size = new System.Drawing.Size(101, 17);
            this.lblTipoListado.TabIndex = 0;
            this.lblTipoListado.Text = "Tipo de listado";
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.dgvResultados);
            this.grpResultados.Location = new System.Drawing.Point(17, 223);
            this.grpResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultados.Size = new System.Drawing.Size(671, 281);
            this.grpResultados.TabIndex = 1;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(8, 44);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(655, 207);
            this.dgvResultados.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 514);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 558);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoEstadisticoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoEstadisticoForm_Load);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbTipoListado;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblTipoListado;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnVolver;
    }
}