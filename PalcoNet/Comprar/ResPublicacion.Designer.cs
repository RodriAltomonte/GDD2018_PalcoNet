namespace PalcoNet.Comprar
{
    partial class ResPublicacion
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
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.BtnSiguiente);
            this.grpResultados.Controls.Add(this.BtnAnterior);
            this.grpResultados.Controls.Add(this.dgvResultados);
            this.grpResultados.Location = new System.Drawing.Point(17, 6);
            this.grpResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResultados.Size = new System.Drawing.Size(1164, 428);
            this.grpResultados.TabIndex = 3;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(591, 386);
            this.BtnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.BtnSiguiente.TabIndex = 3;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(470, 386);
            this.BtnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(100, 28);
            this.BtnAnterior.TabIndex = 2;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(17, 442);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(28, 35);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(1110, 343);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // ResPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 480);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResPublicacion";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.ResultadoPublicacion_Load);
            this.grpResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button btnVolver;
    }
}