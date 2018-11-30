namespace PalcoNet.ABMRol
{
    partial class AltaRol
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
            this.txtRolNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chbxHabilitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRolNombre
            // 
            this.txtRolNombre.Location = new System.Drawing.Point(72, 25);
            this.txtRolNombre.Name = "txtRolNombre";
            this.txtRolNombre.Size = new System.Drawing.Size(211, 20);
            this.txtRolNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(25, 107);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(452, 150);
            this.dgvFuncionalidades.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades";
            // 
            // chbxHabilitado
            // 
            this.chbxHabilitado.AutoSize = true;
            this.chbxHabilitado.Location = new System.Drawing.Point(26, 62);
            this.chbxHabilitado.Name = "chbxHabilitado";
            this.chbxHabilitado.Size = new System.Drawing.Size(56, 17);
            this.chbxHabilitado.TabIndex = 4;
            this.chbxHabilitado.Text = "Activo";
            this.chbxHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(456, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chbxHabilitado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRolNombre);
            this.Name = "AltaRol";
            this.Text = "Alta de Rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbxHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}