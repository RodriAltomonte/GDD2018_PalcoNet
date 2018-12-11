namespace PalcoNet.RegistroUsuario
{
    partial class ModificarPasswordUsuarioForm
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
            this.btnModificarPassword = new System.Windows.Forms.Button();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.lblModificarPass = new System.Windows.Forms.Label();
            this.txtNuevoPassword = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpModificarPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarPassword
            // 
            this.grpModificarPassword.Controls.Add(this.btnModificarPassword);
            this.grpModificarPassword.Controls.Add(this.txtConfirmarPassword);
            this.grpModificarPassword.Controls.Add(this.lblConfirmarPass);
            this.grpModificarPassword.Controls.Add(this.lblModificarPass);
            this.grpModificarPassword.Controls.Add(this.txtNuevoPassword);
            this.grpModificarPassword.Location = new System.Drawing.Point(16, 16);
            this.grpModificarPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificarPassword.Name = "grpModificarPassword";
            this.grpModificarPassword.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificarPassword.Size = new System.Drawing.Size(497, 152);
            this.grpModificarPassword.TabIndex = 0;
            this.grpModificarPassword.TabStop = false;
            this.grpModificarPassword.Text = "Modificar contraseña";
            // 
            // btnModificarPassword
            // 
            this.btnModificarPassword.Location = new System.Drawing.Point(352, 107);
            this.btnModificarPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarPassword.Name = "btnModificarPassword";
            this.btnModificarPassword.Size = new System.Drawing.Size(100, 28);
            this.btnModificarPassword.TabIndex = 1;
            this.btnModificarPassword.Text = "Aceptar";
            this.btnModificarPassword.UseVisualStyleBackColor = true;
            this.btnModificarPassword.Click += new System.EventHandler(this.btnModificarPassword_Click);
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(236, 75);
            this.txtConfirmarPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(215, 22);
            this.txtConfirmarPassword.TabIndex = 4;
            this.txtConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Location = new System.Drawing.Point(67, 79);
            this.lblConfirmarPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(144, 17);
            this.lblConfirmarPass.TabIndex = 5;
            this.lblConfirmarPass.Text = "Confirmar contraseña";
            // 
            // lblModificarPass
            // 
            this.lblModificarPass.AutoSize = true;
            this.lblModificarPass.Location = new System.Drawing.Point(67, 42);
            this.lblModificarPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificarPass.Name = "lblModificarPass";
            this.lblModificarPass.Size = new System.Drawing.Size(124, 17);
            this.lblModificarPass.TabIndex = 2;
            this.lblModificarPass.Text = "Nueva contraseña";
            // 
            // txtNuevoPassword
            // 
            this.txtNuevoPassword.Location = new System.Drawing.Point(236, 38);
            this.txtNuevoPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevoPassword.Name = "txtNuevoPassword";
            this.txtNuevoPassword.Size = new System.Drawing.Size(215, 22);
            this.txtNuevoPassword.TabIndex = 3;
            this.txtNuevoPassword.UseSystemPasswordChar = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 181);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarPasswordUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 222);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpModificarPassword);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarPasswordUsuarioForm";
            this.Text = "ModificarPassword";
            this.grpModificarPassword.ResumeLayout(false);
            this.grpModificarPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarPassword;
        private System.Windows.Forms.Button btnModificarPassword;
        private System.Windows.Forms.Label lblModificarPass;
        private System.Windows.Forms.TextBox txtNuevoPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.Button btnVolver;
    }
}