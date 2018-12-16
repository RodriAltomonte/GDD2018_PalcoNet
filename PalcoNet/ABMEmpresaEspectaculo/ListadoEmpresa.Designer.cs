namespace PalcoNet.ABMEmpresaEspectaculo
{
    partial class ListadoEmpresa
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCUIT1 = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCUIT2 = new System.Windows.Forms.TextBox();
            this.txtCUIT3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(201, 267);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(282, 267);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Location = new System.Drawing.Point(24, 99);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(333, 150);
            this.dgvEmpresas.TabIndex = 14;
            this.dgvEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellContentClick);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(257, 12);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 13;
            // 
            // txtCUIT1
            // 
            this.txtCUIT1.Location = new System.Drawing.Point(167, 38);
            this.txtCUIT1.MaxLength = 8;
            this.txtCUIT1.Name = "txtCUIT1";
            this.txtCUIT1.Size = new System.Drawing.Size(75, 20);
            this.txtCUIT1.TabIndex = 12;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(93, 12);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(107, 20);
            this.txtRazonSocial.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CUIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Razon social";
            // 
            // txtCUIT2
            // 
            this.txtCUIT2.Location = new System.Drawing.Point(116, 37);
            this.txtCUIT2.MaxLength = 2;
            this.txtCUIT2.Name = "txtCUIT2";
            this.txtCUIT2.Size = new System.Drawing.Size(45, 20);
            this.txtCUIT2.TabIndex = 17;
            // 
            // txtCUIT3
            // 
            this.txtCUIT3.Location = new System.Drawing.Point(248, 38);
            this.txtCUIT3.MaxLength = 1;
            this.txtCUIT3.Name = "txtCUIT3";
            this.txtCUIT3.Size = new System.Drawing.Size(45, 20);
            this.txtCUIT3.TabIndex = 17;
            // 
            // ListadoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 380);
            this.Controls.Add(this.txtCUIT3);
            this.Controls.Add(this.txtCUIT2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCUIT1);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEmpresa";
            this.Text = "Listado Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCUIT1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCUIT2;
        private System.Windows.Forms.TextBox txtCUIT3;
    }
}