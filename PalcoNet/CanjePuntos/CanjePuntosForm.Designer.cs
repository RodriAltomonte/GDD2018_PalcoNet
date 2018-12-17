namespace PalcoNet.CanjePuntos
{
    partial class CanjePuntosForm
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
            this.grpConsultaPuntos = new System.Windows.Forms.GroupBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtPuntosValidos = new System.Windows.Forms.TextBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblPuntosValidos = new System.Windows.Forms.Label();
            this.grpCanjePuntos = new System.Windows.Forms.GroupBox();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.cmbPremios = new System.Windows.Forms.ComboBox();
            this.lblItemsCanje = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpConsultaPuntos.SuspendLayout();
            this.grpCanjePuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultaPuntos
            // 
            this.grpConsultaPuntos.Controls.Add(this.txtFechaVencimiento);
            this.grpConsultaPuntos.Controls.Add(this.txtPuntosValidos);
            this.grpConsultaPuntos.Controls.Add(this.lblFechaVencimiento);
            this.grpConsultaPuntos.Controls.Add(this.lblPuntosValidos);
            this.grpConsultaPuntos.Location = new System.Drawing.Point(17, 16);
            this.grpConsultaPuntos.Margin = new System.Windows.Forms.Padding(4);
            this.grpConsultaPuntos.Name = "grpConsultaPuntos";
            this.grpConsultaPuntos.Padding = new System.Windows.Forms.Padding(4);
            this.grpConsultaPuntos.Size = new System.Drawing.Size(505, 126);
            this.grpConsultaPuntos.TabIndex = 0;
            this.grpConsultaPuntos.TabStop = false;
            this.grpConsultaPuntos.Text = "Consulta de puntos";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(227, 65);
            this.txtFechaVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.ReadOnly = true;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(212, 22);
            this.txtFechaVencimiento.TabIndex = 1;
            // 
            // txtPuntosValidos
            // 
            this.txtPuntosValidos.Location = new System.Drawing.Point(227, 33);
            this.txtPuntosValidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuntosValidos.Name = "txtPuntosValidos";
            this.txtPuntosValidos.ReadOnly = true;
            this.txtPuntosValidos.Size = new System.Drawing.Size(212, 22);
            this.txtPuntosValidos.TabIndex = 0;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(59, 69);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(146, 17);
            this.lblFechaVencimiento.TabIndex = 1;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblPuntosValidos
            // 
            this.lblPuntosValidos.AutoSize = true;
            this.lblPuntosValidos.Location = new System.Drawing.Point(59, 37);
            this.lblPuntosValidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosValidos.Name = "lblPuntosValidos";
            this.lblPuntosValidos.Size = new System.Drawing.Size(127, 17);
            this.lblPuntosValidos.TabIndex = 0;
            this.lblPuntosValidos.Text = "Puntos disponibles";
            // 
            // grpCanjePuntos
            // 
            this.grpCanjePuntos.Controls.Add(this.btnCanjear);
            this.grpCanjePuntos.Controls.Add(this.cmbPremios);
            this.grpCanjePuntos.Controls.Add(this.lblItemsCanje);
            this.grpCanjePuntos.Location = new System.Drawing.Point(17, 169);
            this.grpCanjePuntos.Margin = new System.Windows.Forms.Padding(4);
            this.grpCanjePuntos.Name = "grpCanjePuntos";
            this.grpCanjePuntos.Padding = new System.Windows.Forms.Padding(4);
            this.grpCanjePuntos.Size = new System.Drawing.Size(505, 133);
            this.grpCanjePuntos.TabIndex = 1;
            this.grpCanjePuntos.TabStop = false;
            this.grpCanjePuntos.Text = "Canje de puntos";
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(329, 94);
            this.btnCanjear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(137, 28);
            this.btnCanjear.TabIndex = 3;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // cmbPremios
            // 
            this.cmbPremios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPremios.FormattingEnabled = true;
            this.cmbPremios.Location = new System.Drawing.Point(43, 59);
            this.cmbPremios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPremios.Name = "cmbPremios";
            this.cmbPremios.Size = new System.Drawing.Size(423, 24);
            this.cmbPremios.TabIndex = 2;
            // 
            // lblItemsCanje
            // 
            this.lblItemsCanje.AutoSize = true;
            this.lblItemsCanje.Location = new System.Drawing.Point(39, 39);
            this.lblItemsCanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsCanje.Name = "lblItemsCanje";
            this.lblItemsCanje.Size = new System.Drawing.Size(127, 17);
            this.lblItemsCanje.TabIndex = 0;
            this.lblItemsCanje.Text = "Seleccione un item";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(17, 310);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 28);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CanjePuntosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 360);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpCanjePuntos);
            this.Controls.Add(this.grpConsultaPuntos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CanjePuntosForm";
            this.Text = "Canje y administración de puntos";
            this.grpConsultaPuntos.ResumeLayout(false);
            this.grpConsultaPuntos.PerformLayout();
            this.grpCanjePuntos.ResumeLayout(false);
            this.grpCanjePuntos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaPuntos;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtPuntosValidos;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblPuntosValidos;
        private System.Windows.Forms.GroupBox grpCanjePuntos;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.ComboBox cmbPremios;
        private System.Windows.Forms.Label lblItemsCanje;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnVolver;
    }
}