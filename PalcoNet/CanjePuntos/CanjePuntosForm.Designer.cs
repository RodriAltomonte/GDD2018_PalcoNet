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
            this.grpConsultaPuntos.Location = new System.Drawing.Point(13, 13);
            this.grpConsultaPuntos.Name = "grpConsultaPuntos";
            this.grpConsultaPuntos.Size = new System.Drawing.Size(379, 102);
            this.grpConsultaPuntos.TabIndex = 0;
            this.grpConsultaPuntos.TabStop = false;
            this.grpConsultaPuntos.Text = "Consulta de puntos";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(170, 53);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.ReadOnly = true;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(160, 20);
            this.txtFechaVencimiento.TabIndex = 3;
            // 
            // txtPuntosValidos
            // 
            this.txtPuntosValidos.Location = new System.Drawing.Point(170, 27);
            this.txtPuntosValidos.Name = "txtPuntosValidos";
            this.txtPuntosValidos.ReadOnly = true;
            this.txtPuntosValidos.Size = new System.Drawing.Size(160, 20);
            this.txtPuntosValidos.TabIndex = 2;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(44, 56);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 1;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblPuntosValidos
            // 
            this.lblPuntosValidos.AutoSize = true;
            this.lblPuntosValidos.Location = new System.Drawing.Point(44, 30);
            this.lblPuntosValidos.Name = "lblPuntosValidos";
            this.lblPuntosValidos.Size = new System.Drawing.Size(95, 13);
            this.lblPuntosValidos.TabIndex = 0;
            this.lblPuntosValidos.Text = "Puntos disponibles";
            // 
            // grpCanjePuntos
            // 
            this.grpCanjePuntos.Controls.Add(this.btnCanjear);
            this.grpCanjePuntos.Controls.Add(this.cmbPremios);
            this.grpCanjePuntos.Controls.Add(this.lblItemsCanje);
            this.grpCanjePuntos.Location = new System.Drawing.Point(13, 137);
            this.grpCanjePuntos.Name = "grpCanjePuntos";
            this.grpCanjePuntos.Size = new System.Drawing.Size(379, 122);
            this.grpCanjePuntos.TabIndex = 1;
            this.grpCanjePuntos.TabStop = false;
            this.grpCanjePuntos.Text = "Canje de puntos";
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(247, 76);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(103, 23);
            this.btnCanjear.TabIndex = 2;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // cmbPremios
            // 
            this.cmbPremios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPremios.FormattingEnabled = true;
            this.cmbPremios.Location = new System.Drawing.Point(32, 48);
            this.cmbPremios.Name = "cmbPremios";
            this.cmbPremios.Size = new System.Drawing.Size(318, 21);
            this.cmbPremios.TabIndex = 1;
            // 
            // lblItemsCanje
            // 
            this.lblItemsCanje.AutoSize = true;
            this.lblItemsCanje.Location = new System.Drawing.Point(29, 32);
            this.lblItemsCanje.Name = "lblItemsCanje";
            this.lblItemsCanje.Size = new System.Drawing.Size(97, 13);
            this.lblItemsCanje.TabIndex = 0;
            this.lblItemsCanje.Text = "Seleccione un item";
            // 
            // CanjePuntosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 277);
            this.Controls.Add(this.grpCanjePuntos);
            this.Controls.Add(this.grpConsultaPuntos);
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
    }
}