namespace PalcoNet.RegistroUsuario
{
    partial class RegistroDeUsuarioForm
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpRegistroUsuario = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpRegistroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(309, 151);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(144, 106);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(264, 24);
            this.cmbRoles.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 46);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 78);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Location = new System.Drawing.Point(8, 110);
            this.lblRolUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(107, 17);
            this.lblRolUsuario.TabIndex = 4;
            this.lblRolUsuario.Text = "Tipo de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(144, 42);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(264, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(264, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // grpRegistroUsuario
            // 
            this.grpRegistroUsuario.Controls.Add(this.lblUsername);
            this.grpRegistroUsuario.Controls.Add(this.txtPassword);
            this.grpRegistroUsuario.Controls.Add(this.btnSiguiente);
            this.grpRegistroUsuario.Controls.Add(this.txtUsername);
            this.grpRegistroUsuario.Controls.Add(this.cmbRoles);
            this.grpRegistroUsuario.Controls.Add(this.lblRolUsuario);
            this.grpRegistroUsuario.Controls.Add(this.lblPassword);
            this.grpRegistroUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpRegistroUsuario.Location = new System.Drawing.Point(19, 27);
            this.grpRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRegistroUsuario.Name = "grpRegistroUsuario";
            this.grpRegistroUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRegistroUsuario.Size = new System.Drawing.Size(437, 198);
            this.grpRegistroUsuario.TabIndex = 7;
            this.grpRegistroUsuario.TabStop = false;
            this.grpRegistroUsuario.Text = "Registro de usuario";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(19, 233);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RegistroDeUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 274);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpRegistroUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroDeUsuarioForm";
            this.Text = "RegistroDeUsuario";
            this.grpRegistroUsuario.ResumeLayout(false);
            this.grpRegistroUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpRegistroUsuario;
        private System.Windows.Forms.Button btnVolver;
    }
}