namespace PalcoNet.RegistroUsuario
{
    partial class ModificarPasswordPorAdmin
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
            this.grpModificarPassword = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.lblNuevoPass = new System.Windows.Forms.Label();
            this.txtNuevoPass = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grpModificarPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarPassword
            // 
            this.grpModificarPassword.Controls.Add(this.txtBuscar);
            this.grpModificarPassword.Controls.Add(this.btnBuscar);
            this.grpModificarPassword.Controls.Add(this.lblBuscar);
            this.grpModificarPassword.Controls.Add(this.dgvUsuarios);
            this.grpModificarPassword.Location = new System.Drawing.Point(13, 13);
            this.grpModificarPassword.Name = "grpModificarPassword";
            this.grpModificarPassword.Size = new System.Drawing.Size(394, 218);
            this.grpModificarPassword.TabIndex = 0;
            this.grpModificarPassword.TabStop = false;
            this.grpModificarPassword.Text = "Buscar usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 94);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(345, 112);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(26, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(82, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(299, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnModificar);
            this.grpModificar.Controls.Add(this.txtNuevoPass);
            this.grpModificar.Controls.Add(this.lblNuevoPass);
            this.grpModificar.Controls.Add(this.txtUsuarioSeleccionado);
            this.grpModificar.Controls.Add(this.lblSeleccionado);
            this.grpModificar.Location = new System.Drawing.Point(13, 247);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(394, 120);
            this.grpModificar.TabIndex = 1;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar contraseña";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(29, 34);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(109, 13);
            this.lblSeleccionado.TabIndex = 0;
            this.lblSeleccionado.Text = "Usuario seleccionado";
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(144, 31);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.ReadOnly = true;
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(230, 20);
            this.txtUsuarioSeleccionado.TabIndex = 1;
            // 
            // lblNuevoPass
            // 
            this.lblNuevoPass.AutoSize = true;
            this.lblNuevoPass.Location = new System.Drawing.Point(29, 60);
            this.lblNuevoPass.Name = "lblNuevoPass";
            this.lblNuevoPass.Size = new System.Drawing.Size(95, 13);
            this.lblNuevoPass.TabIndex = 2;
            this.lblNuevoPass.Text = "Nueva contraseña";
            // 
            // txtNuevoPass
            // 
            this.txtNuevoPass.Location = new System.Drawing.Point(144, 57);
            this.txtNuevoPass.Name = "txtNuevoPass";
            this.txtNuevoPass.Size = new System.Drawing.Size(230, 20);
            this.txtNuevoPass.TabIndex = 3;
            this.txtNuevoPass.UseSystemPasswordChar = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(299, 83);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificarPasswordPorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 383);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpModificarPassword);
            this.Name = "ModificarPasswordPorAdmin";
            this.Text = "ModificarPasswordPorAdmin";
            this.grpModificarPassword.ResumeLayout(false);
            this.grpModificarPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarPassword;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNuevoPass;
        private System.Windows.Forms.Label lblNuevoPass;
        private System.Windows.Forms.TextBox txtUsuarioSeleccionado;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}