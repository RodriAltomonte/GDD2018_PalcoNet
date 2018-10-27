namespace PalcoNet.Login
{
    partial class SeleccionarFuncionalidadForm
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
            this.grpFuncionalidad = new System.Windows.Forms.GroupBox();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpFuncionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuncionalidad
            // 
            this.grpFuncionalidad.Controls.Add(this.btnVolver);
            this.grpFuncionalidad.Controls.Add(this.btnAceptar);
            this.grpFuncionalidad.Controls.Add(this.cmbFuncionalidades);
            this.grpFuncionalidad.Location = new System.Drawing.Point(25, 13);
            this.grpFuncionalidad.Name = "grpFuncionalidad";
            this.grpFuncionalidad.Size = new System.Drawing.Size(276, 130);
            this.grpFuncionalidad.TabIndex = 0;
            this.grpFuncionalidad.TabStop = false;
            this.grpFuncionalidad.Text = "Seleccionar funcionalidad";
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(7, 20);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(261, 21);
            this.cmbFuncionalidades.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(6, 47);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(261, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(7, 98);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // SeleccionarFuncionalidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 169);
            this.Controls.Add(this.grpFuncionalidad);
            this.Name = "SeleccionarFuncionalidadForm";
            this.Text = "SeleccionarFuncionalidadForm";
            this.grpFuncionalidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuncionalidad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
    }
}