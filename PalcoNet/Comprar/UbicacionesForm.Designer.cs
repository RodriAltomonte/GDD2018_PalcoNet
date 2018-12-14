namespace PalcoNet.Comprar
{
    partial class UbicacionesForm
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
            this.dgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUbicaciones
            // 
            this.dgvUbicaciones.AllowUserToAddRows = false;
            this.dgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbicaciones.Location = new System.Drawing.Point(21, 40);
            this.dgvUbicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUbicaciones.Name = "dgvUbicaciones";
            this.dgvUbicaciones.ReadOnly = true;
            this.dgvUbicaciones.Size = new System.Drawing.Size(617, 230);
            this.dgvUbicaciones.TabIndex = 0;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(538, 289);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 28);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(430, 289);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUbicaciones);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 336);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // UbicacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 359);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UbicacionesForm";
            this.Text = "UbicacionesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUbicaciones;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}