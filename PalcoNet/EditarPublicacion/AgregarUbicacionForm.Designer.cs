﻿namespace PalcoNet.EditarPublicacion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblFila = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbTipoUbicacion = new System.Windows.Forms.ComboBox();
            this.rdbFilasAsientos = new System.Windows.Forms.RadioButton();
            this.rdbSinNumerar = new System.Windows.Forms.RadioButton();
            this.lblTipoUbicacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAgregarUbicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgregarUbicacion
            // 
            this.grpAgregarUbicacion.Controls.Add(this.btnAceptar);
            this.grpAgregarUbicacion.Controls.Add(this.txtAsientos);
            this.grpAgregarUbicacion.Controls.Add(this.lblAsientos);
            this.grpAgregarUbicacion.Controls.Add(this.lblFila);
            this.grpAgregarUbicacion.Controls.Add(this.txtFila);
            this.grpAgregarUbicacion.Controls.Add(this.txtPrecio);
            this.grpAgregarUbicacion.Controls.Add(this.cmbTipoUbicacion);
            this.grpAgregarUbicacion.Controls.Add(this.rdbFilasAsientos);
            this.grpAgregarUbicacion.Controls.Add(this.rdbSinNumerar);
            this.grpAgregarUbicacion.Controls.Add(this.lblTipoUbicacion);
            this.grpAgregarUbicacion.Controls.Add(this.lblPrecio);
            this.grpAgregarUbicacion.Controls.Add(this.label1);
            this.grpAgregarUbicacion.Location = new System.Drawing.Point(12, 12);
            this.grpAgregarUbicacion.Name = "grpAgregarUbicacion";
            this.grpAgregarUbicacion.Size = new System.Drawing.Size(260, 219);
            this.grpAgregarUbicacion.TabIndex = 1;
            this.grpAgregarUbicacion.TabStop = false;
            this.grpAgregarUbicacion.Text = "Agregar ubicación";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 183);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(119, 124);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(122, 20);
            this.txtAsientos.TabIndex = 14;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(13, 127);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(101, 13);
            this.lblAsientos.TabIndex = 13;
            this.lblAsientos.Text = "Cantidad de lugares";
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(81, 153);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(23, 13);
            this.lblFila.TabIndex = 10;
            this.lblFila.Text = "Fila";
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(119, 150);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(121, 20);
            this.txtFila.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(121, 69);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // cmbTipoUbicacion
            // 
            this.cmbTipoUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUbicacion.FormattingEnabled = true;
            this.cmbTipoUbicacion.Location = new System.Drawing.Point(120, 95);
            this.cmbTipoUbicacion.Name = "cmbTipoUbicacion";
            this.cmbTipoUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUbicacion.TabIndex = 7;
            // 
            // rdbFilasAsientos
            // 
            this.rdbFilasAsientos.AutoSize = true;
            this.rdbFilasAsientos.Location = new System.Drawing.Point(23, 46);
            this.rdbFilasAsientos.Name = "rdbFilasAsientos";
            this.rdbFilasAsientos.Size = new System.Drawing.Size(112, 17);
            this.rdbFilasAsientos.TabIndex = 6;
            this.rdbFilasAsientos.TabStop = true;
            this.rdbFilasAsientos.Text = "Por filas y asientos";
            this.rdbFilasAsientos.UseVisualStyleBackColor = true;
            this.rdbFilasAsientos.CheckedChanged += new System.EventHandler(this.rdbFilasAsientos_CheckedChanged);
            // 
            // rdbSinNumerar
            // 
            this.rdbSinNumerar.AutoSize = true;
            this.rdbSinNumerar.Location = new System.Drawing.Point(23, 23);
            this.rdbSinNumerar.Name = "rdbSinNumerar";
            this.rdbSinNumerar.Size = new System.Drawing.Size(81, 17);
            this.rdbSinNumerar.TabIndex = 5;
            this.rdbSinNumerar.TabStop = true;
            this.rdbSinNumerar.Text = "Sin numerar";
            this.rdbSinNumerar.UseVisualStyleBackColor = true;
            this.rdbSinNumerar.CheckedChanged += new System.EventHandler(this.rdbSinNumerar_CheckedChanged);
            // 
            // lblTipoUbicacion
            // 
            this.lblTipoUbicacion.AutoSize = true;
            this.lblTipoUbicacion.Location = new System.Drawing.Point(22, 98);
            this.lblTipoUbicacion.Name = "lblTipoUbicacion";
            this.lblTipoUbicacion.Size = new System.Drawing.Size(92, 13);
            this.lblTipoUbicacion.TabIndex = 2;
            this.lblTipoUbicacion.Text = "Tipo de ubicación";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(77, 72);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // AgregarUbicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.grpAgregarUbicacion);
            this.Name = "AgregarUbicacionForm";
            this.Text = "AgregarUbicacionForm";
            this.grpAgregarUbicacion.ResumeLayout(false);
            this.grpAgregarUbicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarUbicacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbTipoUbicacion;
        private System.Windows.Forms.RadioButton rdbFilasAsientos;
        private System.Windows.Forms.RadioButton rdbSinNumerar;
        private System.Windows.Forms.Label lblTipoUbicacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label1;
    }
}