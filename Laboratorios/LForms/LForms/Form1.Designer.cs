namespace LForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.Nombre_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bryant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Nombre_txt.Location = new System.Drawing.Point(12, 133);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(776, 22);
            this.Nombre_txt.TabIndex = 1;
            // 
            // Nombre_lbl
            // 
            this.Nombre_lbl.AutoSize = true;
            this.Nombre_lbl.Location = new System.Drawing.Point(380, 255);
            this.Nombre_lbl.Name = "Nombre_lbl";
            this.Nombre_lbl.Size = new System.Drawing.Size(44, 16);
            this.Nombre_lbl.TabIndex = 2;
            this.Nombre_lbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nombre_lbl);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Nombre_txt;
        private System.Windows.Forms.Label Nombre_lbl;
    }
}

