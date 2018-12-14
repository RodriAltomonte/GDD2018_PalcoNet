namespace PalcoNet.ABMGrado
{
    partial class BajaGradoForm
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
            this.grpGrado = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaja = new System.Windows.Forms.ComboBox();
            this.grpGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrado
            // 
            this.grpGrado.Controls.Add(this.btnCancelar);
            this.grpGrado.Controls.Add(this.btnBaja);
            this.grpGrado.Controls.Add(this.label1);
            this.grpGrado.Controls.Add(this.cmbBaja);
            this.grpGrado.Location = new System.Drawing.Point(12, 12);
            this.grpGrado.Name = "grpGrado";
            this.grpGrado.Size = new System.Drawing.Size(436, 136);
            this.grpGrado.TabIndex = 1;
            this.grpGrado.TabStop = false;
            this.grpGrado.Text = "Baja de Grado de Publicación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(313, 93);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 28);
            this.btnBaja.TabIndex = 22;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccionar";
            // 
            // cmbBaja
            // 
            this.cmbBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaja.FormattingEnabled = true;
            this.cmbBaja.Location = new System.Drawing.Point(134, 39);
            this.cmbBaja.Name = "cmbBaja";
            this.cmbBaja.Size = new System.Drawing.Size(279, 24);
            this.cmbBaja.TabIndex = 20;
            // 
            // BajaGradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 164);
            this.Controls.Add(this.grpGrado);
            this.Name = "BajaGradoForm";
            this.Text = "BajaGradoForm";
            this.grpGrado.ResumeLayout(false);
            this.grpGrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaja;
    }
}