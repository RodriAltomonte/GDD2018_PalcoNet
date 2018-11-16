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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "a",
            "2",
            "123",
            "asd",
            "a"}, -1);
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpGenerarPublicacion = new System.Windows.Forms.GroupBox();
            this.lvUbicaciones = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLimpiarFechaHora = new System.Windows.Forms.Button();
            this.btnRemoverFechaHora = new System.Windows.Forms.Button();
            this.btnAgregarFechaHora = new System.Windows.Forms.Button();
            this.btnLimpiarUbicaciones = new System.Windows.Forms.Button();
            this.btnRemoveUbicacion = new System.Windows.Forms.Button();
            this.btnAgregarUbicacion = new System.Windows.Forms.Button();
            this.dtpFechaEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.dtpHoraEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblFechaHoraEspectaculo = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblUbicaciones = new System.Windows.Forms.Label();
            this.lbUbicaciones = new System.Windows.Forms.ListBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rTxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.tTipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tTipRemover = new System.Windows.Forms.ToolTip(this.components);
            this.tTipLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.lvFechaHora = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpGenerarPublicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 560);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grpGenerarPublicacion
            // 
            this.grpGenerarPublicacion.Controls.Add(this.lvFechaHora);
            this.grpGenerarPublicacion.Controls.Add(this.lvUbicaciones);
            this.grpGenerarPublicacion.Controls.Add(this.btnLimpiarFechaHora);
            this.grpGenerarPublicacion.Controls.Add(this.btnRemoverFechaHora);
            this.grpGenerarPublicacion.Controls.Add(this.btnAgregarFechaHora);
            this.grpGenerarPublicacion.Controls.Add(this.btnLimpiarUbicaciones);
            this.grpGenerarPublicacion.Controls.Add(this.btnRemoveUbicacion);
            this.grpGenerarPublicacion.Controls.Add(this.btnAgregarUbicacion);
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
            this.grpGenerarPublicacion.Size = new System.Drawing.Size(651, 541);
            this.grpGenerarPublicacion.TabIndex = 2;
            this.grpGenerarPublicacion.TabStop = false;
            this.grpGenerarPublicacion.Text = "Nueva publicación";
            // 
            // lvUbicaciones
            // 
            this.lvUbicaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUbicaciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvUbicaciones.Location = new System.Drawing.Point(172, 111);
            this.lvUbicaciones.Name = "lvUbicaciones";
            this.lvUbicaciones.Size = new System.Drawing.Size(334, 97);
            this.lvUbicaciones.TabIndex = 25;
            this.lvUbicaciones.UseCompatibleStateImageBehavior = false;
            this.lvUbicaciones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fila";
            this.columnHeader6.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Asientos";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sin numerar";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo de ubicación";
            this.columnHeader5.Width = 98;
            // 
            // btnLimpiarFechaHora
            // 
            this.btnLimpiarFechaHora.Location = new System.Drawing.Point(122, 336);
            this.btnLimpiarFechaHora.Name = "btnLimpiarFechaHora";
            this.btnLimpiarFechaHora.Size = new System.Drawing.Size(33, 20);
            this.btnLimpiarFechaHora.TabIndex = 24;
            this.btnLimpiarFechaHora.Text = "x";
            this.tTipLimpiar.SetToolTip(this.btnLimpiarFechaHora, "Limpiar");
            this.btnLimpiarFechaHora.UseVisualStyleBackColor = true;
            // 
            // btnRemoverFechaHora
            // 
            this.btnRemoverFechaHora.Location = new System.Drawing.Point(122, 312);
            this.btnRemoverFechaHora.Name = "btnRemoverFechaHora";
            this.btnRemoverFechaHora.Size = new System.Drawing.Size(33, 19);
            this.btnRemoverFechaHora.TabIndex = 23;
            this.btnRemoverFechaHora.Text = "-";
            this.tTipRemover.SetToolTip(this.btnRemoverFechaHora, "Remover");
            this.btnRemoverFechaHora.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFechaHora
            // 
            this.btnAgregarFechaHora.Location = new System.Drawing.Point(122, 287);
            this.btnAgregarFechaHora.Name = "btnAgregarFechaHora";
            this.btnAgregarFechaHora.Size = new System.Drawing.Size(33, 19);
            this.btnAgregarFechaHora.TabIndex = 22;
            this.btnAgregarFechaHora.Text = "+";
            this.tTipAgregar.SetToolTip(this.btnAgregarFechaHora, "Añadir");
            this.btnAgregarFechaHora.UseVisualStyleBackColor = true;
            this.btnAgregarFechaHora.Click += new System.EventHandler(this.btnAgregarFechaHora_Click);
            // 
            // btnLimpiarUbicaciones
            // 
            this.btnLimpiarUbicaciones.Location = new System.Drawing.Point(122, 186);
            this.btnLimpiarUbicaciones.Name = "btnLimpiarUbicaciones";
            this.btnLimpiarUbicaciones.Size = new System.Drawing.Size(33, 20);
            this.btnLimpiarUbicaciones.TabIndex = 21;
            this.btnLimpiarUbicaciones.Text = "x";
            this.tTipLimpiar.SetToolTip(this.btnLimpiarUbicaciones, "Limpiar");
            this.btnLimpiarUbicaciones.UseVisualStyleBackColor = true;
            this.btnLimpiarUbicaciones.Click += new System.EventHandler(this.btnLimpiarUbicaciones_Click);
            // 
            // btnRemoveUbicacion
            // 
            this.btnRemoveUbicacion.Location = new System.Drawing.Point(122, 161);
            this.btnRemoveUbicacion.Name = "btnRemoveUbicacion";
            this.btnRemoveUbicacion.Size = new System.Drawing.Size(33, 19);
            this.btnRemoveUbicacion.TabIndex = 20;
            this.btnRemoveUbicacion.Text = "-";
            this.tTipRemover.SetToolTip(this.btnRemoveUbicacion, "Remover");
            this.btnRemoveUbicacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUbicacion
            // 
            this.btnAgregarUbicacion.Location = new System.Drawing.Point(122, 136);
            this.btnAgregarUbicacion.Name = "btnAgregarUbicacion";
            this.btnAgregarUbicacion.Size = new System.Drawing.Size(33, 19);
            this.btnAgregarUbicacion.TabIndex = 19;
            this.btnAgregarUbicacion.Text = "+";
            this.tTipAgregar.SetToolTip(this.btnAgregarUbicacion, "Añadir");
            this.btnAgregarUbicacion.UseVisualStyleBackColor = true;
            this.btnAgregarUbicacion.Click += new System.EventHandler(this.btnAgregarUbicacion_Click);
            // 
            // dtpFechaEspectaculo
            // 
            this.dtpFechaEspectaculo.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEspectaculo.Location = new System.Drawing.Point(-1, 135);
            this.dtpFechaEspectaculo.Name = "dtpFechaEspectaculo";
            this.dtpFechaEspectaculo.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaEspectaculo.TabIndex = 17;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(431, 504);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(43, 458);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(112, 13);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado de publicación";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(172, 455);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(334, 21);
            this.cmbEstado.TabIndex = 14;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(47, 431);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(108, 13);
            this.lblGrado.TabIndex = 13;
            this.lblGrado.Text = "Grado de publicación";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(172, 428);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(334, 21);
            this.cmbGrado.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(172, 402);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(334, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(103, 405);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(172, 375);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(334, 21);
            this.cmbRubro.TabIndex = 9;
            // 
            // dtpHoraEspectaculo
            // 
            this.dtpHoraEspectaculo.CustomFormat = "HH:mm";
            this.dtpHoraEspectaculo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEspectaculo.Location = new System.Drawing.Point(10, 161);
            this.dtpHoraEspectaculo.Name = "dtpHoraEspectaculo";
            this.dtpHoraEspectaculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHoraEspectaculo.ShowUpDown = true;
            this.dtpHoraEspectaculo.Size = new System.Drawing.Size(83, 20);
            this.dtpHoraEspectaculo.TabIndex = 8;
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
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(119, 378);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(36, 13);
            this.lblRubro.TabIndex = 6;
            this.lblRubro.Text = "Rubro";
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
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(46, 233);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(109, 13);
            this.lblFechaPublicacion.TabIndex = 4;
            this.lblFechaPublicacion.Text = "Fecha de publicación";
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
            // lbUbicaciones
            // 
            this.lbUbicaciones.FormattingEnabled = true;
            this.lbUbicaciones.HorizontalScrollbar = true;
            this.lbUbicaciones.Location = new System.Drawing.Point(160, 482);
            this.lbUbicaciones.MultiColumn = true;
            this.lbUbicaciones.Name = "lbUbicaciones";
            this.lbUbicaciones.Size = new System.Drawing.Size(334, 108);
            this.lbUbicaciones.TabIndex = 0;
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
            // rTxtDescripcion
            // 
            this.rTxtDescripcion.Location = new System.Drawing.Point(172, 36);
            this.rTxtDescripcion.Name = "rTxtDescripcion";
            this.rTxtDescripcion.Size = new System.Drawing.Size(334, 60);
            this.rTxtDescripcion.TabIndex = 0;
            this.rTxtDescripcion.Text = "";
            // 
            // lvFechaHora
            // 
            this.lvFechaHora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7});
            this.lvFechaHora.Location = new System.Drawing.Point(172, 261);
            this.lvFechaHora.Name = "lvFechaHora";
            this.lvFechaHora.Size = new System.Drawing.Size(334, 97);
            this.lvFechaHora.TabIndex = 26;
            this.lvFechaHora.UseCompatibleStateImageBehavior = false;
            this.lvFechaHora.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hora";
            this.columnHeader7.Width = 128;
            // 
            // GenerarPublicacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 595);
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
        private System.Windows.Forms.Button btnLimpiarUbicaciones;
        private System.Windows.Forms.Button btnRemoveUbicacion;
        private System.Windows.Forms.Button btnAgregarUbicacion;
        private System.Windows.Forms.ToolTip tTipAgregar;
        private System.Windows.Forms.ToolTip tTipLimpiar;
        private System.Windows.Forms.ToolTip tTipRemover;
        private System.Windows.Forms.Button btnLimpiarFechaHora;
        private System.Windows.Forms.Button btnRemoverFechaHora;
        private System.Windows.Forms.Button btnAgregarFechaHora;
        private System.Windows.Forms.ListView lvUbicaciones;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvFechaHora;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}