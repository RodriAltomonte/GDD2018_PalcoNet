namespace PalcoNet.EditarPublicacion
{
    partial class AgregarUbicacionForm
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
            this.grpAgregarUbicacion = new System.Windows.Forms.GroupBox();
            this.nudCantidadLugares = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblFila = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.cmbTipoUbicacion = new System.Windows.Forms.ComboBox();
            this.rdbFilasAsientos = new System.Windows.Forms.RadioButton();
            this.rdbSinNumerar = new System.Windows.Forms.RadioButton();
            this.lblTipoUbicacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAgregarUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadLugares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarUbicacion
            // 
            this.grpAgregarUbicacion.Controls.Add(this.nudCantidadLugares);
            this.grpAgregarUbicacion.Controls.Add(this.nudPrecio);
            this.grpAgregarUbicacion.Controls.Add(this.btnAceptar);
            this.grpAgregarUbicacion.Controls.Add(this.lblAsientos);
            this.grpAgregarUbicacion.Controls.Add(this.lblFila);
            this.grpAgregarUbicacion.Controls.Add(this.txtFila);
            this.grpAgregarUbicacion.Controls.Add(this.cmbTipoUbicacion);
            this.grpAgregarUbicacion.Controls.Add(this.rdbFilasAsientos);
            this.grpAgregarUbicacion.Controls.Add(this.rdbSinNumerar);
            this.grpAgregarUbicacion.Controls.Add(this.lblTipoUbicacion);
            this.grpAgregarUbicacion.Controls.Add(this.lblPrecio);
            this.grpAgregarUbicacion.Controls.Add(this.label1);
            this.grpAgregarUbicacion.Location = new System.Drawing.Point(16, 15);
            this.grpAgregarUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.grpAgregarUbicacion.Name = "grpAgregarUbicacion";
            this.grpAgregarUbicacion.Padding = new System.Windows.Forms.Padding(4);
            this.grpAgregarUbicacion.Size = new System.Drawing.Size(347, 270);
            this.grpAgregarUbicacion.TabIndex = 1;
            this.grpAgregarUbicacion.TabStop = false;
            this.grpAgregarUbicacion.Text = "Agregar ubicación";
            // 
            // nudCantidadLugares
            // 
            this.nudCantidadLugares.Location = new System.Drawing.Point(159, 156);
            this.nudCantidadLugares.Maximum = decimal.MaxValue;
            this.nudCantidadLugares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadLugares.Name = "nudCantidadLugares";
            this.nudCantidadLugares.Size = new System.Drawing.Size(160, 22);
            this.nudCantidadLugares.TabIndex = 17;
            this.nudCantidadLugares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(159, 89);
            this.nudPrecio.Maximum = decimal.MaxValue;
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(160, 22);
            this.nudPrecio.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(221, 225);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(17, 156);
            this.lblAsientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(135, 17);
            this.lblAsientos.TabIndex = 13;
            this.lblAsientos.Text = "Cantidad de lugares";
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(108, 188);
            this.lblFila.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(30, 17);
            this.lblFila.TabIndex = 10;
            this.lblFila.Text = "Fila";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(159, 185);
            this.txtFila.Margin = new System.Windows.Forms.Padding(4);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(160, 22);
            this.txtFila.TabIndex = 9;
            // 
            // cmbTipoUbicacion
            // 
            this.cmbTipoUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUbicacion.FormattingEnabled = true;
            this.cmbTipoUbicacion.Location = new System.Drawing.Point(161, 121);
            this.cmbTipoUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUbicacion.Name = "cmbTipoUbicacion";
            this.cmbTipoUbicacion.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoUbicacion.TabIndex = 7;
            // 
            // rdbFilasAsientos
            // 
            this.rdbFilasAsientos.AutoSize = true;
            this.rdbFilasAsientos.Location = new System.Drawing.Point(31, 57);
            this.rdbFilasAsientos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFilasAsientos.Name = "rdbFilasAsientos";
            this.rdbFilasAsientos.Size = new System.Drawing.Size(148, 21);
            this.rdbFilasAsientos.TabIndex = 6;
            this.rdbFilasAsientos.TabStop = true;
            this.rdbFilasAsientos.Text = "Por filas y asientos";
            this.rdbFilasAsientos.UseVisualStyleBackColor = true;
            this.rdbFilasAsientos.CheckedChanged += new System.EventHandler(this.rdbFilasAsientos_CheckedChanged);
            // 
            // rdbSinNumerar
            // 
            this.rdbSinNumerar.AutoSize = true;
            this.rdbSinNumerar.Location = new System.Drawing.Point(31, 28);
            this.rdbSinNumerar.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSinNumerar.Name = "rdbSinNumerar";
            this.rdbSinNumerar.Size = new System.Drawing.Size(106, 21);
            this.rdbSinNumerar.TabIndex = 5;
            this.rdbSinNumerar.TabStop = true;
            this.rdbSinNumerar.Text = "Sin numerar";
            this.rdbSinNumerar.UseVisualStyleBackColor = true;
            this.rdbSinNumerar.CheckedChanged += new System.EventHandler(this.rdbSinNumerar_CheckedChanged);
            // 
            // lblTipoUbicacion
            // 
            this.lblTipoUbicacion.AutoSize = true;
            this.lblTipoUbicacion.Location = new System.Drawing.Point(29, 121);
            this.lblTipoUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUbicacion.Name = "lblTipoUbicacion";
            this.lblTipoUbicacion.Size = new System.Drawing.Size(120, 17);
            this.lblTipoUbicacion.TabIndex = 2;
            this.lblTipoUbicacion.Text = "Tipo de ubicación";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(103, 89);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // AgregarUbicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 299);
            this.Controls.Add(this.grpAgregarUbicacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarUbicacionForm";
            this.Text = "AgregarUbicacionForm";
            this.grpAgregarUbicacion.ResumeLayout(false);
            this.grpAgregarUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadLugares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarUbicacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.ComboBox cmbTipoUbicacion;
        private System.Windows.Forms.RadioButton rdbFilasAsientos;
        private System.Windows.Forms.RadioButton rdbSinNumerar;
        private System.Windows.Forms.Label lblTipoUbicacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCantidadLugares;
        private System.Windows.Forms.NumericUpDown nudPrecio;
    }
}