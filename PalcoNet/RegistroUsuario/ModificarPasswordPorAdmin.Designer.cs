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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNuevoPass = new System.Windows.Forms.TextBox();
            this.lblNuevoPass = new System.Windows.Forms.Label();
            this.txtUsuarioSeleccionado = new System.Windows.Forms.TextBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grpModificarPassword.Location = new System.Drawing.Point(17, 16);
            this.grpModificarPassword.Margin = new System.Windows.Forms.Padding(4);
            this.grpModificarPassword.Name = "grpModificarPassword";
            this.grpModificarPassword.Padding = new System.Windows.Forms.Padding(4);
            this.grpModificarPassword.Size = new System.Drawing.Size(525, 268);
            this.grpModificarPassword.TabIndex = 0;
            this.grpModificarPassword.TabStop = false;
            this.grpModificarPassword.Text = "Buscar usuarios";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(152, 36);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(345, 22);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 68);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(35, 39);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(110, 17);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(39, 116);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(460, 138);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.label1);
            this.grpModificar.Controls.Add(this.txtConfirmar);
            this.grpModificar.Controls.Add(this.btnModificar);
            this.grpModificar.Controls.Add(this.txtNuevoPass);
            this.grpModificar.Controls.Add(this.lblNuevoPass);
            this.grpModificar.Controls.Add(this.txtUsuarioSeleccionado);
            this.grpModificar.Controls.Add(this.lblSeleccionado);
            this.grpModificar.Location = new System.Drawing.Point(17, 304);
            this.grpModificar.Margin = new System.Windows.Forms.Padding(4);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Padding = new System.Windows.Forms.Padding(4);
            this.grpModificar.Size = new System.Drawing.Size(525, 169);
            this.grpModificar.TabIndex = 1;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar contraseña";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(399, 130);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNuevoPass
            // 
            this.txtNuevoPass.Location = new System.Drawing.Point(192, 70);
            this.txtNuevoPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoPass.Name = "txtNuevoPass";
            this.txtNuevoPass.Size = new System.Drawing.Size(305, 22);
            this.txtNuevoPass.TabIndex = 3;
            this.txtNuevoPass.UseSystemPasswordChar = true;
            // 
            // lblNuevoPass
            // 
            this.lblNuevoPass.AutoSize = true;
            this.lblNuevoPass.Location = new System.Drawing.Point(39, 74);
            this.lblNuevoPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoPass.Name = "lblNuevoPass";
            this.lblNuevoPass.Size = new System.Drawing.Size(124, 17);
            this.lblNuevoPass.TabIndex = 2;
            this.lblNuevoPass.Text = "Nueva contraseña";
            // 
            // txtUsuarioSeleccionado
            // 
            this.txtUsuarioSeleccionado.Location = new System.Drawing.Point(192, 38);
            this.txtUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            this.txtUsuarioSeleccionado.ReadOnly = true;
            this.txtUsuarioSeleccionado.Size = new System.Drawing.Size(305, 22);
            this.txtUsuarioSeleccionado.TabIndex = 1;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(39, 42);
            this.lblSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(144, 17);
            this.lblSeleccionado.TabIndex = 0;
            this.lblSeleccionado.Text = "Usuario seleccionado";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(17, 481);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(192, 100);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(305, 22);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar contraseña";
            // 
            // ModificarPasswordPorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 522);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpModificarPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmar;
    }
}