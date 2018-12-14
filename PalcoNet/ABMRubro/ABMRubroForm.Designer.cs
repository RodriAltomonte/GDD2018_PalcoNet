namespace PalcoNet.ABMRubro
{
    partial class ABMRubroForm
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpGrado = new System.Windows.Forms.GroupBox();
            this.cmbABM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 157);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpGrado
            // 
            this.grpGrado.Controls.Add(this.cmbABM);
            this.grpGrado.Controls.Add(this.label1);
            this.grpGrado.Controls.Add(this.btnAceptar);
            this.grpGrado.Location = new System.Drawing.Point(12, 12);
            this.grpGrado.Name = "grpGrado";
            this.grpGrado.Size = new System.Drawing.Size(338, 139);
            this.grpGrado.TabIndex = 4;
            this.grpGrado.TabStop = false;
            this.grpGrado.Text = "ABM de Rubro";
            // 
            // cmbABM
            // 
            this.cmbABM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbABM.FormattingEnabled = true;
            this.cmbABM.Items.AddRange(new object[] {
            "Alta",
            "Baja",
            "Modificacion"});
            this.cmbABM.Location = new System.Drawing.Point(21, 52);
            this.cmbABM.Name = "cmbABM";
            this.cmbABM.Size = new System.Drawing.Size(296, 24);
            this.cmbABM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una acción";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 91);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ABMRubroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 195);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpGrado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMRubroForm";
            this.Text = "Rubro";
            this.grpGrado.ResumeLayout(false);
            this.grpGrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpGrado;
        private System.Windows.Forms.ComboBox cmbABM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}