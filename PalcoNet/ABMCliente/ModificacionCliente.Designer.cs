namespace PalcoNet.ABMCliente
{
    partial class ModificacionCliente
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
            this.cbxHabilitado = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.Departamento = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.Piso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.Verificador1 = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodPostal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.Calle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.DigitoVerificador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxHabilitado
            // 
            this.cbxHabilitado.AutoSize = true;
            this.cbxHabilitado.Location = new System.Drawing.Point(409, 297);
            this.cbxHabilitado.Name = "cbxHabilitado";
            this.cbxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.cbxHabilitado.TabIndex = 16;
            this.cbxHabilitado.Text = "Habilitado";
            this.cbxHabilitado.UseVisualStyleBackColor = true;
            this.cbxHabilitado.Click += new System.EventHandler(this.cbxHabilitado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(355, 355);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(436, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(50, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE",
            "CARNET EXT.",
            "RUC",
            "P. NACI.",
            "OTROS"});
            this.cboTipoDoc.Location = new System.Drawing.Point(117, 64);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(116, 21);
            this.cboTipoDoc.TabIndex = 2;
            // 
            // Departamento
            // 
            this.Departamento.Location = new System.Drawing.Point(436, 149);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(53, 20);
            this.Departamento.TabIndex = 9;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(400, 152);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(30, 13);
            this.lblDpto.TabIndex = 93;
            this.lblDpto.Text = "Dpto";
            // 
            // Piso
            // 
            this.Piso.Location = new System.Drawing.Point(358, 149);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(36, 20);
            this.Piso.TabIndex = 8;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(325, 152);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 91;
            this.lblPiso.Text = "Piso";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(147, 320);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaNacimiento.TabIndex = 17;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(25, 320);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 87;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // Verificador1
            // 
            this.Verificador1.Location = new System.Drawing.Point(117, 233);
            this.Verificador1.MaxLength = 2;
            this.Verificador1.Name = "Verificador1";
            this.Verificador1.Size = new System.Drawing.Size(33, 20);
            this.Verificador1.TabIndex = 12;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(58, 236);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(32, 13);
            this.lblNacionalidad.TabIndex = 85;
            this.lblNacionalidad.Text = "CUIT";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(117, 259);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(372, 20);
            this.txtTarjeta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tarjeta";
            // 
            // CodPostal
            // 
            this.CodPostal.Location = new System.Drawing.Point(136, 181);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(353, 20);
            this.CodPostal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Codigo Postal";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(117, 207);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(372, 20);
            this.Localidad.TabIndex = 11;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(58, 210);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 79;
            this.lblLocalidad.Text = "Localidad";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(273, 149);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(46, 20);
            this.Numero.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(223, 152);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 77;
            this.lblNumero.Text = "Numero";
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(117, 149);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(100, 20);
            this.Calle.TabIndex = 6;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(81, 152);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 75;
            this.lblCalle.Text = "Calle";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(117, 123);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(372, 20);
            this.Telefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(63, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 73;
            this.lblTelefono.Text = "Telefono";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(117, 94);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(372, 20);
            this.Mail.TabIndex = 4;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(85, 97);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 71;
            this.lblMail.Text = "Mail";
            // 
            // Documento
            // 
            this.Documento.Location = new System.Drawing.Point(358, 64);
            this.Documento.MaxLength = 8;
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(131, 20);
            this.Documento.TabIndex = 3;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(250, 67);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(102, 13);
            this.lblNroDocumento.TabIndex = 69;
            this.lblNroDocumento.Text = "Numero Documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(25, 67);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 68;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(117, 38);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(372, 20);
            this.Apellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(67, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 66;
            this.lblApellido.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(117, 12);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(372, 20);
            this.Nombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 64;
            this.lblNombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "-";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(172, 233);
            this.DNI.MaxLength = 8;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(74, 20);
            this.DNI.TabIndex = 13;
            // 
            // DigitoVerificador
            // 
            this.DigitoVerificador.Location = new System.Drawing.Point(263, 233);
            this.DigitoVerificador.MaxLength = 1;
            this.DigitoVerificador.Name = "DigitoVerificador";
            this.DigitoVerificador.Size = new System.Drawing.Size(27, 20);
            this.DigitoVerificador.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "-";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(383, 320);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaCreacion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Fecha de creacion";
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxHabilitado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.lblDpto);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.DigitoVerificador);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Verificador1);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodPostal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.Calle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "ModificacionCliente";
            this.Text = "Modificacion cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxHabilitado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox Departamento;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.TextBox Piso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox Verificador1;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodPostal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox Documento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.TextBox DigitoVerificador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label label1;
    }
}