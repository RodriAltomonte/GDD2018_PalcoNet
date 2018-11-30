namespace PalcoNet.ABMRol
{
    partial class ModificarFuncionalidadesRol
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
            this.btnAddFuncionalidad = new System.Windows.Forms.Button();
            this.btnDelFuncionalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFuncionalidad
            // 
            this.btnAddFuncionalidad.Location = new System.Drawing.Point(87, 12);
            this.btnAddFuncionalidad.Name = "btnAddFuncionalidad";
            this.btnAddFuncionalidad.Size = new System.Drawing.Size(161, 23);
            this.btnAddFuncionalidad.TabIndex = 0;
            this.btnAddFuncionalidad.Text = "AgregarFuncionalidad";
            this.btnAddFuncionalidad.UseVisualStyleBackColor = true;
            this.btnAddFuncionalidad.Click += new System.EventHandler(this.btnAddFuncionalidad_Click);
            // 
            // btnDelFuncionalidad
            // 
            this.btnDelFuncionalidad.Location = new System.Drawing.Point(87, 50);
            this.btnDelFuncionalidad.Name = "btnDelFuncionalidad";
            this.btnDelFuncionalidad.Size = new System.Drawing.Size(161, 23);
            this.btnDelFuncionalidad.TabIndex = 1;
            this.btnDelFuncionalidad.Text = "BorrarFuncionalidad";
            this.btnDelFuncionalidad.UseVisualStyleBackColor = true;
            this.btnDelFuncionalidad.Click += new System.EventHandler(this.btnDelFuncionalidad_Click);
            // 
            // ModificarFuncionalidadesRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 120);
            this.Controls.Add(this.btnDelFuncionalidad);
            this.Controls.Add(this.btnAddFuncionalidad);
            this.Name = "ModificarFuncionalidadesRol";
            this.Text = "ModificarFuncionalidadesRol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFuncionalidad;
        private System.Windows.Forms.Button btnDelFuncionalidad;
    }
}