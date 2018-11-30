namespace PalcoNet.ABMRol
{
    partial class ModificarNombreRol
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
            this.txtNombreAntiguo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreAntiguo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreAntiguo
            // 
            this.txtNombreAntiguo.Location = new System.Drawing.Point(125, 12);
            this.txtNombreAntiguo.Name = "txtNombreAntiguo";
            this.txtNombreAntiguo.Size = new System.Drawing.Size(265, 20);
            this.txtNombreAntiguo.TabIndex = 0;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(125, 38);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(265, 20);
            this.txtNombreNuevo.TabIndex = 1;
            // 
            // lblNombreAntiguo
            // 
            this.lblNombreAntiguo.AutoSize = true;
            this.lblNombreAntiguo.Location = new System.Drawing.Point(26, 15);
            this.lblNombreAntiguo.Name = "lblNombreAntiguo";
            this.lblNombreAntiguo.Size = new System.Drawing.Size(83, 13);
            this.lblNombreAntiguo.TabIndex = 2;
            this.lblNombreAntiguo.Text = "Nombre Anterior";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(26, 41);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(79, 13);
            this.lblNombreNuevo.TabIndex = 3;
            this.lblNombreNuevo.Text = "Nombre Nuevo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(314, 75);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ModificarNombreRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 109);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombreNuevo);
            this.Controls.Add(this.lblNombreAntiguo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.txtNombreAntiguo);
            this.Name = "ModificarNombreRol";
            this.Text = "ModificarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAntiguo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label lblNombreAntiguo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}