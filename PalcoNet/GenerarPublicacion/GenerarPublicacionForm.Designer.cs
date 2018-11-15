namespace PalcoNet.GenerarPublicacion
{
    partial class GenerarPublicacionForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpGenerarPublicacion = new System.Windows.Forms.GroupBox();
            this.rTxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lbUbicaciones = new System.Windows.Forms.ListBox();
            this.lblUbicaciones = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblFechaHoraEspectaculo = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dtpFechaEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.grpGenerarPublicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpGenerarPublicacion
            // 
            this.grpGenerarPublicacion.Controls.Add(this.dtpFechaEspectaculo);
            this.grpGenerarPublicacion.Controls.Add(this.btnCrear);
            this.grpGenerarPublicacion.Controls.Add(this.lblEstado);
            this.grpGenerarPublicacion.Controls.Add(this.cmbEstado);
            this.grpGenerarPublicacion.Controls.Add(this.lblGrado);
            this.grpGenerarPublicacion.Controls.Add(this.cmbGrado);
            this.grpGenerarPublicacion.Controls.Add(this.txtDireccion);
            this.grpGenerarPublicacion.Controls.Add(this.lblDireccion);
            this.grpGenerarPublicacion.Controls.Add(this.cmbRubro);
            this.grpGenerarPublicacion.Controls.Add(this.dtpHoraEspectaculo);
            this.grpGenerarPublicacion.Controls.Add(this.dtpFechaPublicacion);
            this.grpGenerarPublicacion.Controls.Add(this.lblRubro);
            this.grpGenerarPublicacion.Controls.Add(this.lblFechaHoraEspectaculo);
            this.grpGenerarPublicacion.Controls.Add(this.lblFechaPublicacion);
            this.grpGenerarPublicacion.Controls.Add(this.lblUbicaciones);
            this.grpGenerarPublicacion.Controls.Add(this.lbUbicaciones);
            this.grpGenerarPublicacion.Controls.Add(this.lblDescripcion);
            this.grpGenerarPublicacion.Controls.Add(this.rTxtDescripcion);
            this.grpGenerarPublicacion.Location = new System.Drawing.Point(13, 13);
            this.grpGenerarPublicacion.Name = "grpGenerarPublicacion";
            this.grpGenerarPublicacion.Size = new System.Drawing.Size(523, 443);
            this.grpGenerarPublicacion.TabIndex = 2;
            this.grpGenerarPublicacion.TabStop = false;
            this.grpGenerarPublicacion.Text = "Nueva publicación";
            // 
            // rTxtDescripcion
            // 
            this.rTxtDescripcion.Location = new System.Drawing.Point(172, 36);
            this.rTxtDescripcion.Name = "rTxtDescripcion";
            this.rTxtDescripcion.Size = new System.Drawing.Size(334, 60);
            this.rTxtDescripcion.TabIndex = 0;
            this.rTxtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(92, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lbUbicaciones
            // 
            this.lbUbicaciones.FormattingEnabled = true;
            this.lbUbicaciones.Location = new System.Drawing.Point(172, 111);
            this.lbUbicaciones.Name = "lbUbicaciones";
            this.lbUbicaciones.Size = new System.Drawing.Size(334, 95);
            this.lbUbicaciones.TabIndex = 2;
            // 
            // lblUbicaciones
            // 
            this.lblUbicaciones.AutoSize = true;
            this.lblUbicaciones.Location = new System.Drawing.Point(89, 111);
            this.lblUbicaciones.Name = "lblUbicaciones";
            this.lblUbicaciones.Size = new System.Drawing.Size(66, 13);
            this.lblUbicaciones.TabIndex = 3;
            this.lblUbicaciones.Text = "Ubicaciones";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(46, 233);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(109, 13);
            this.lblFechaPublicacion.TabIndex = 4;
            this.lblFechaPublicacion.Text = "Fecha de publicación";
            // 
            // lblFechaHoraEspectaculo
            // 
            this.lblFechaHoraEspectaculo.AutoSize = true;
            this.lblFechaHoraEspectaculo.Location = new System.Drawing.Point(10, 261);
            this.lblFechaHoraEspectaculo.Name = "lblFechaHoraEspectaculo";
            this.lblFechaHoraEspectaculo.Size = new System.Drawing.Size(145, 13);
            this.lblFechaHoraEspectaculo.TabIndex = 5;
            this.lblFechaHoraEspectaculo.Text = "Fecha y hora de espectáculo";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(119, 284);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(36, 13);
            this.lblRubro.TabIndex = 6;
            this.lblRubro.Text = "Rubro";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(172, 227);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaPublicacion.TabIndex = 7;
            // 
            // dtpHoraEspectaculo
            // 
            this.dtpHoraEspectaculo.CustomFormat = "HH:mm";
            this.dtpHoraEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEspectaculo.Location = new System.Drawing.Point(290, 255);
            this.dtpHoraEspectaculo.Name = "dtpHoraEspectaculo";
            this.dtpHoraEspectaculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHoraEspectaculo.ShowUpDown = true;
            this.dtpHoraEspectaculo.Size = new System.Drawing.Size(83, 20);
            this.dtpHoraEspectaculo.TabIndex = 8;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(172, 281);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(334, 21);
            this.cmbRubro.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(103, 311);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(172, 308);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(334, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(172, 334);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(334, 21);
            this.cmbGrado.TabIndex = 12;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(47, 337);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(108, 13);
            this.lblGrado.TabIndex = 13;
            this.lblGrado.Text = "Grado de publicación";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(172, 361);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(334, 21);
            this.cmbEstado.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(43, 364);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado de publicación";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(431, 410);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dtpFechaEspectaculo
            // 
            this.dtpFechaEspectaculo.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEspectaculo.Location = new System.Drawing.Point(172, 255);
            this.dtpFechaEspectaculo.Name = "dtpFechaEspectaculo";
            this.dtpFechaEspectaculo.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaEspectaculo.TabIndex = 17;
            // 
            // GenerarPublicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 505);
            this.Controls.Add(this.grpGenerarPublicacion);
            this.Controls.Add(this.btnVolver);
            this.Name = "GenerarPublicacionForm";
            this.Text = "GenerarPublicacionForm";
            this.grpGenerarPublicacion.ResumeLayout(false);
            this.grpGenerarPublicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox grpGenerarPublicacion;
        private System.Windows.Forms.RichTextBox rTxtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.DateTimePicker dtpHoraEspectaculo;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblFechaHoraEspectaculo;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblUbicaciones;
        private System.Windows.Forms.ListBox lbUbicaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaEspectaculo;
    }
}