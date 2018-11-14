namespace PalcoNet.RegistroUsuario
{
    partial class DarDeBajaUsuarioForm
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
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.grpBaja = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpBuscar.SuspendLayout();
            this.grpBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.dgvUsuarios);
            this.grpBuscar.Controls.Add(this.txtBuscar);
            this.grpBuscar.Controls.Add(this.lblBuscar);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(13, 13);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(391, 247);
            this.grpBuscar.TabIndex = 0;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // grpBaja
            // 
            this.grpBaja.Controls.Add(this.txtUsuarioSeleccionado);
            this.grpBaja.Controls.Add(this.lblUsuarioSeleccionado);
            this.grpBaja.Controls.Add(this.btnBaja);
            this.grpBaja.Location = new System.Drawing.Point(13, 266);
            this.grpBaja.Name = "grpBaja";
            this.grpBaja.Size = new System.Drawing.Size(391, 85);
            this.grpBaja.TabIndex = 1;
            this.grpBaja.TabStop = false;
            this.grpBaja.Text = "Dar de baja";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(298, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(298, 50);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(32, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(82, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar usuarios";
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(16, 27);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(109, 13);
            this.lblUsuarioSeleccionado.TabIndex = 2;
            this.lblUsuarioSeleccionado.Text = "Usuario seleccionado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(253, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(131, 24);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.ReadOnly = true;
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(242, 20);
            this.txtUsuarioSeleccionado.TabIndex = 3;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 94);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(355, 134);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // DarDeBajaUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 365);
            this.Controls.Add(this.grpBaja);
            this.Controls.Add(this.grpBuscar);
            this.Name = "DarDeBajaUsuarioForm";
            this.Text = "DarDeBajaUsuarioForm";
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpBaja.ResumeLayout(false);
            this.grpBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpBaja;
        private System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Button btnBaja;
    }
}