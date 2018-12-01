namespace PalcoNet.ABMCliente
{
    partial class AltaCliente
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
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.cbxHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.cboTipoDoc.Location = new System.Drawing.Point(96, 64);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(116, 21);
            this.cboTipoDoc.TabIndex = 59;
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(415, 149);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(53, 20);
            this.txtDpto.TabIndex = 58;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(379, 152);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(30, 13);
            this.lblDpto.TabIndex = 57;
            this.lblDpto.Text = "Dpto";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(337, 149);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(36, 20);
            this.txtPiso.TabIndex = 56;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(304, 152);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 55;
            this.lblPiso.Text = "Piso";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(126, 320);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaNacimiento.TabIndex = 53;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(14, 320);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 52;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(96, 233);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(372, 20);
            this.txtCUIL.TabIndex = 51;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(37, 236);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(31, 13);
            this.lblNacionalidad.TabIndex = 50;
            this.lblNacionalidad.Text = "CUIL";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(96, 207);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(372, 20);
            this.txtLocalidad.TabIndex = 49;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(37, 210);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 48;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(252, 149);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(46, 20);
            this.txtNumero.TabIndex = 47;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(202, 152);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 46;
            this.lblNumero.Text = "Numero";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(96, 149);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 45;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(60, 152);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 44;
            this.lblCalle.Text = "Calle";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(372, 20);
            this.txtTelefono.TabIndex = 43;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(42, 126);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 42;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(96, 94);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(372, 20);
            this.txtMail.TabIndex = 41;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(64, 97);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 40;
            this.lblMail.Text = "Mail";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(337, 64);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(131, 20);
            this.txtNroDocumento.TabIndex = 39;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(229, 67);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(102, 13);
            this.lblNroDocumento.TabIndex = 38;
            this.lblNroDocumento.Text = "Numero Documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(4, 67);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 37;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(372, 20);
            this.txtApellido.TabIndex = 36;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(46, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Fecha de creacion";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(369, 320);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaCreacion.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tarjeta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(96, 259);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(372, 20);
            this.txtTarjeta.TabIndex = 49;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(334, 355);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 62;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(415, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(29, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Codigo Postal";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(115, 181);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(353, 20);
            this.txtPostal.TabIndex = 49;
            // 
            // cbxHabilitado
            // 
            this.cbxHabilitado.AutoSize = true;
            this.cbxHabilitado.Location = new System.Drawing.Point(388, 297);
            this.cbxHabilitado.Name = "cbxHabilitado";
            this.cbxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.cbxHabilitado.TabIndex = 63;
            this.cbxHabilitado.Text = "Habilitado";
            this.cbxHabilitado.UseVisualStyleBackColor = true;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 382);
            this.Controls.Add(this.cbxHabilitado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.txtDpto);
            this.Controls.Add(this.lblDpto);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.CheckBox cbxHabilitado;
    }
}