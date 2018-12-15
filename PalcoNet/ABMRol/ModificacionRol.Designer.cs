namespace PalcoNet.ABMRol
{
    partial class ModificacionRol
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
            this.btnModNombre = new System.Windows.Forms.Button();
            this.btnModFuncs = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModNombre
            // 
            this.btnModNombre.Location = new System.Drawing.Point(50, 12);
            this.btnModNombre.Name = "btnModNombre";
            this.btnModNombre.Size = new System.Drawing.Size(169, 23);
            this.btnModNombre.TabIndex = 0;
            this.btnModNombre.Text = "Modificar Nombre";
            this.btnModNombre.UseVisualStyleBackColor = true;
            this.btnModNombre.Click += new System.EventHandler(this.btnModNombre_Click);
            // 
            // btnModFuncs
            // 
            this.btnModFuncs.Location = new System.Drawing.Point(50, 41);
            this.btnModFuncs.Name = "btnModFuncs";
            this.btnModFuncs.Size = new System.Drawing.Size(169, 23);
            this.btnModFuncs.TabIndex = 0;
            this.btnModFuncs.Text = "Modificar Funcionalidades";
            this.btnModFuncs.UseVisualStyleBackColor = true;
            this.btnModFuncs.Click += new System.EventHandler(this.btnModFuncs_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 70);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 99);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModFuncs);
            this.Controls.Add(this.btnModNombre);
            this.Name = "ModificacionRol";
            this.Text = "ModificacionRol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModNombre;
        private System.Windows.Forms.Button btnModFuncs;
        private System.Windows.Forms.Button btnVolver;
    }
}