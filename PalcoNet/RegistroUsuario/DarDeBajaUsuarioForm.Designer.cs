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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpBaja = new System.Windows.Forms.GroupBox();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.dgvUsuarios);
            this.grpBuscar.Controls.Add(this.txtBuscar);
            this.grpBuscar.Controls.Add(this.lblBuscar);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(17, 16);
            this.grpBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBuscar.Size = new System.Drawing.Size(521, 304);
            this.grpBuscar.TabIndex = 0;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(23, 104);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(473, 165);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(160, 26);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(43, 30);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(110, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(397, 58);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpBaja
            // 
            this.grpBaja.Controls.Add(this.txtUsuarioSeleccionado);
            this.grpBaja.Controls.Add(this.lblUsuarioSeleccionado);
            this.grpBaja.Controls.Add(this.btnBaja);
            this.grpBaja.Location = new System.Drawing.Point(17, 327);
            this.grpBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBaja.Name = "grpBaja";
            this.grpBaja.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBaja.Size = new System.Drawing.Size(521, 105);
            this.grpBaja.TabIndex = 1;
            this.grpBaja.TabStop = false;
            this.grpBaja.Text = "Dar de baja";
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(175, 30);
            this.txtUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.ReadOnly = true;
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(321, 22);
            this.txtUsuarioSeleccionado.TabIndex = 3;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(21, 33);
            this.lblUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(144, 17);
            this.lblUsuarioSeleccionado.TabIndex = 2;
            this.lblUsuarioSeleccionado.Text = "Usuario seleccionado";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(397, 62);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 28);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(17, 440);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DarDeBajaUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 480);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpBaja);
            this.Controls.Add(this.grpBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DarDeBajaUsuarioForm";
            this.Text = "DarDeBajaUsuarioForm";
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpBaja.ResumeLayout(false);
            this.grpBaja.PerformLayout();
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
        private System.Windows.Forms.Button btnVolver;
    }
}