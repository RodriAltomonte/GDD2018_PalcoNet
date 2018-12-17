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
            this.btnModNombre.Location = new System.Drawing.Point(67, 15);
            this.btnModNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModNombre.Name = "btnModNombre";
            this.btnModNombre.Size = new System.Drawing.Size(225, 28);
            this.btnModNombre.TabIndex = 0;
            this.btnModNombre.Text = "Modificar Nombre";
            this.btnModNombre.UseVisualStyleBackColor = true;
            this.btnModNombre.Click += new System.EventHandler(this.btnModNombre_Click);
            // 
            // btnModFuncs
            // 
            this.btnModFuncs.Location = new System.Drawing.Point(67, 50);
            this.btnModFuncs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModFuncs.Name = "btnModFuncs";
            this.btnModFuncs.Size = new System.Drawing.Size(225, 28);
            this.btnModFuncs.TabIndex = 1;
            this.btnModFuncs.Text = "Modificar Funcionalidades";
            this.btnModFuncs.UseVisualStyleBackColor = true;
            this.btnModFuncs.Click += new System.EventHandler(this.btnModFuncs_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 86);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 122);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModFuncs);
            this.Controls.Add(this.btnModNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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