namespace PalcoNet.EditarPublicacion
{
    partial class EditarPublicacionSeleccionada
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
            this.grpEditarPublicacion = new System.Windows.Forms.GroupBox();
            this.dgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpHoraEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveUbicacion = new System.Windows.Forms.Button();
            this.btnAgregarUbicacion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblFechaHoraEspectaculo = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblUbicaciones = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rTxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.grpEditarPublicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditarPublicacion
            // 
            this.grpEditarPublicacion.Controls.Add(this.dgvUbicaciones);
            this.grpEditarPublicacion.Controls.Add(this.btnCancelar);
            this.grpEditarPublicacion.Controls.Add(this.dtpHoraEspectaculo);
            this.grpEditarPublicacion.Controls.Add(this.dtpFechaDeEspectaculo);
            this.grpEditarPublicacion.Controls.Add(this.lblVencimiento);
            this.grpEditarPublicacion.Controls.Add(this.dtpVencimiento);
            this.grpEditarPublicacion.Controls.Add(this.btnRemoveUbicacion);
            this.grpEditarPublicacion.Controls.Add(this.btnAgregarUbicacion);
            this.grpEditarPublicacion.Controls.Add(this.btnActualizar);
            this.grpEditarPublicacion.Controls.Add(this.lblEstado);
            this.grpEditarPublicacion.Controls.Add(this.cmbEstado);
            this.grpEditarPublicacion.Controls.Add(this.lblGrado);
            this.grpEditarPublicacion.Controls.Add(this.cmbGrado);
            this.grpEditarPublicacion.Controls.Add(this.txtDireccion);
            this.grpEditarPublicacion.Controls.Add(this.lblDireccion);
            this.grpEditarPublicacion.Controls.Add(this.cmbRubro);
            this.grpEditarPublicacion.Controls.Add(this.dtpFechaPublicacion);
            this.grpEditarPublicacion.Controls.Add(this.lblRubro);
            this.grpEditarPublicacion.Controls.Add(this.lblFechaHoraEspectaculo);
            this.grpEditarPublicacion.Controls.Add(this.lblFechaPublicacion);
            this.grpEditarPublicacion.Controls.Add(this.lblUbicaciones);
            this.grpEditarPublicacion.Controls.Add(this.lblDescripcion);
            this.grpEditarPublicacion.Controls.Add(this.rTxtDescripcion);
            this.grpEditarPublicacion.Location = new System.Drawing.Point(16, 15);
            this.grpEditarPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.grpEditarPublicacion.Name = "grpEditarPublicacion";
            this.grpEditarPublicacion.Padding = new System.Windows.Forms.Padding(4);
            this.grpEditarPublicacion.Size = new System.Drawing.Size(711, 613);
            this.grpEditarPublicacion.TabIndex = 3;
            this.grpEditarPublicacion.TabStop = false;
            this.grpEditarPublicacion.Text = "Editar publicación";
            // 
            // dgvUbicaciones
            // 
            this.dgvUbicaciones.AllowUserToAddRows = false;
            this.dgvUbicaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUbicaciones.ColumnHeadersHeight = 20;
            this.dgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUbicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUbicaciones.Location = new System.Drawing.Point(229, 160);
            this.dgvUbicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUbicaciones.MultiSelect = false;
            this.dgvUbicaciones.Name = "dgvUbicaciones";
            this.dgvUbicaciones.ReadOnly = true;
            this.dgvUbicaciones.RowHeadersWidth = 31;
            this.dgvUbicaciones.Size = new System.Drawing.Size(445, 119);
            this.dgvUbicaciones.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ubicacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo de ubicación";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IdTipoUbicacion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nuevo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 555);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpHoraEspectaculo
            // 
            this.dtpHoraEspectaculo.CustomFormat = "HH:mm";
            this.dtpHoraEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEspectaculo.Location = new System.Drawing.Point(387, 321);
            this.dtpHoraEspectaculo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraEspectaculo.Name = "dtpHoraEspectaculo";
            this.dtpHoraEspectaculo.ShowUpDown = true;
            this.dtpHoraEspectaculo.Size = new System.Drawing.Size(148, 22);
            this.dtpHoraEspectaculo.TabIndex = 5;
            // 
            // dtpFechaDeEspectaculo
            // 
            this.dtpFechaDeEspectaculo.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDeEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeEspectaculo.Location = new System.Drawing.Point(229, 321);
            this.dtpFechaDeEspectaculo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDeEspectaculo.Name = "dtpFechaDeEspectaculo";
            this.dtpFechaDeEspectaculo.Size = new System.Drawing.Size(148, 22);
            this.dtpFechaDeEspectaculo.TabIndex = 4;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(61, 353);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(146, 17);
            this.lblVencimiento.TabIndex = 28;
            this.lblVencimiento.Text = "Fecha de vencimiento";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(229, 353);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(148, 22);
            this.dtpVencimiento.TabIndex = 6;
            // 
            // btnRemoveUbicacion
            // 
            this.btnRemoveUbicacion.Location = new System.Drawing.Point(163, 198);
            this.btnRemoveUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveUbicacion.Name = "btnRemoveUbicacion";
            this.btnRemoveUbicacion.Size = new System.Drawing.Size(44, 23);
            this.btnRemoveUbicacion.TabIndex = 2;
            this.btnRemoveUbicacion.Text = "-";
            this.btnRemoveUbicacion.UseVisualStyleBackColor = true;
            this.btnRemoveUbicacion.Click += new System.EventHandler(this.btnRemoveUbicacion_Click);
            // 
            // btnAgregarUbicacion
            // 
            this.btnAgregarUbicacion.Location = new System.Drawing.Point(163, 167);
            this.btnAgregarUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUbicacion.Name = "btnAgregarUbicacion";
            this.btnAgregarUbicacion.Size = new System.Drawing.Size(44, 23);
            this.btnAgregarUbicacion.TabIndex = 1;
            this.btnAgregarUbicacion.Text = "+";
            this.btnAgregarUbicacion.UseVisualStyleBackColor = true;
            this.btnAgregarUbicacion.Click += new System.EventHandler(this.btnAgregarUbicacion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(575, 554);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(57, 498);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(147, 17);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado de publicación";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(229, 495);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(444, 24);
            this.cmbEstado.TabIndex = 10;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(63, 465);
            this.lblGrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(143, 17);
            this.lblGrado.TabIndex = 13;
            this.lblGrado.Text = "Grado de publicación";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(229, 462);
            this.cmbGrado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(444, 24);
            this.cmbGrado.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(229, 430);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(444, 22);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(137, 433);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(229, 396);
            this.cmbRubro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(444, 24);
            this.cmbRubro.TabIndex = 7;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(229, 287);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(148, 22);
            this.dtpFechaPublicacion.TabIndex = 3;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(159, 400);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(47, 17);
            this.lblRubro.TabIndex = 6;
            this.lblRubro.Text = "Rubro";
            // 
            // lblFechaHoraEspectaculo
            // 
            this.lblFechaHoraEspectaculo.AutoSize = true;
            this.lblFechaHoraEspectaculo.Location = new System.Drawing.Point(13, 321);
            this.lblFechaHoraEspectaculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHoraEspectaculo.Name = "lblFechaHoraEspectaculo";
            this.lblFechaHoraEspectaculo.Size = new System.Drawing.Size(191, 17);
            this.lblFechaHoraEspectaculo.TabIndex = 5;
            this.lblFechaHoraEspectaculo.Text = "Fecha y hora de espectáculo";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(61, 287);
            this.lblFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(142, 17);
            this.lblFechaPublicacion.TabIndex = 4;
            this.lblFechaPublicacion.Text = "Fecha de publicación";
            // 
            // lblUbicaciones
            // 
            this.lblUbicaciones.AutoSize = true;
            this.lblUbicaciones.Location = new System.Drawing.Point(119, 137);
            this.lblUbicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicaciones.Name = "lblUbicaciones";
            this.lblUbicaciones.Size = new System.Drawing.Size(85, 17);
            this.lblUbicaciones.TabIndex = 3;
            this.lblUbicaciones.Text = "Ubicaciones";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(123, 44);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // rTxtDescripcion
            // 
            this.rTxtDescripcion.Location = new System.Drawing.Point(229, 44);
            this.rTxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtDescripcion.Name = "rTxtDescripcion";
            this.rTxtDescripcion.Size = new System.Drawing.Size(444, 73);
            this.rTxtDescripcion.TabIndex = 0;
            this.rTxtDescripcion.Text = "";
            // 
            // EditarPublicacionSeleccionada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 651);
            this.Controls.Add(this.grpEditarPublicacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarPublicacionSeleccionada";
            this.Text = "EditarPublicacionSeleccionada";
            this.grpEditarPublicacion.ResumeLayout(false);
            this.grpEditarPublicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditarPublicacion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnRemoveUbicacion;
        private System.Windows.Forms.Button btnAgregarUbicacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblFechaHoraEspectaculo;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblUbicaciones;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rTxtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpHoraEspectaculo;
        private System.Windows.Forms.DateTimePicker dtpFechaDeEspectaculo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUbicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}