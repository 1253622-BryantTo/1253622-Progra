namespace L10__BT1253622
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ImputDescripccion = new System.Windows.Forms.RichTextBox();
            this.ImputPrecio = new System.Windows.Forms.NumericUpDown();
            this.InputMarca = new System.Windows.Forms.TextBox();
            this.ImputModelo = new System.Windows.Forms.NumericUpDown();
            this.BtnCargarDatos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OutputPrecioFinal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ImputIva = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.OutputDescripccion = new System.Windows.Forms.Label();
            this.OutputModelo = new System.Windows.Forms.Label();
            this.OutputPrecio = new System.Windows.Forms.Label();
            this.OutputMarcar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImputPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImputModelo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImputIva)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ImputDescripccion);
            this.tabPage1.Controls.Add(this.ImputPrecio);
            this.tabPage1.Controls.Add(this.InputMarca);
            this.tabPage1.Controls.Add(this.ImputModelo);
            this.tabPage1.Controls.Add(this.BtnCargarDatos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ImputDescripccion
            // 
            this.ImputDescripccion.Location = new System.Drawing.Point(141, 192);
            this.ImputDescripccion.Name = "ImputDescripccion";
            this.ImputDescripccion.Size = new System.Drawing.Size(621, 91);
            this.ImputDescripccion.TabIndex = 9;
            this.ImputDescripccion.Text = "";
            // 
            // ImputPrecio
            // 
            this.ImputPrecio.DecimalPlaces = 2;
            this.ImputPrecio.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.ImputPrecio.Location = new System.Drawing.Point(141, 144);
            this.ImputPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ImputPrecio.Name = "ImputPrecio";
            this.ImputPrecio.Size = new System.Drawing.Size(621, 22);
            this.ImputPrecio.TabIndex = 8;
            // 
            // InputMarca
            // 
            this.InputMarca.Location = new System.Drawing.Point(141, 51);
            this.InputMarca.Name = "InputMarca";
            this.InputMarca.Size = new System.Drawing.Size(621, 22);
            this.InputMarca.TabIndex = 7;
            // 
            // ImputModelo
            // 
            this.ImputModelo.Location = new System.Drawing.Point(141, 97);
            this.ImputModelo.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.ImputModelo.Minimum = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.ImputModelo.Name = "ImputModelo";
            this.ImputModelo.Size = new System.Drawing.Size(621, 22);
            this.ImputModelo.TabIndex = 6;
            this.ImputModelo.ThousandsSeparator = true;
            this.ImputModelo.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            // 
            // BtnCargarDatos
            // 
            this.BtnCargarDatos.Location = new System.Drawing.Point(141, 298);
            this.BtnCargarDatos.Name = "BtnCargarDatos";
            this.BtnCargarDatos.Size = new System.Drawing.Size(621, 93);
            this.BtnCargarDatos.TabIndex = 5;
            this.BtnCargarDatos.Text = "Cargar Datos";
            this.BtnCargarDatos.UseVisualStyleBackColor = true;
            this.BtnCargarDatos.Click += new System.EventHandler(this.BtnCargarDatos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carros";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OutputPrecioFinal);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.ImputIva);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.OutputDescripccion);
            this.tabPage2.Controls.Add(this.OutputModelo);
            this.tabPage2.Controls.Add(this.OutputPrecio);
            this.tabPage2.Controls.Add(this.OutputMarcar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OutputPrecioFinal
            // 
            this.OutputPrecioFinal.AutoSize = true;
            this.OutputPrecioFinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPrecioFinal.Location = new System.Drawing.Point(193, 370);
            this.OutputPrecioFinal.Name = "OutputPrecioFinal";
            this.OutputPrecioFinal.Size = new System.Drawing.Size(99, 24);
            this.OutputPrecioFinal.TabIndex = 19;
            this.OutputPrecioFinal.Text = "Precio Final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Precio Final:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(740, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calcular Precio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImputIva
            // 
            this.ImputIva.DecimalPlaces = 2;
            this.ImputIva.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ImputIva.Location = new System.Drawing.Point(197, 232);
            this.ImputIva.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ImputIva.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ImputIva.Name = "ImputIva";
            this.ImputIva.Size = new System.Drawing.Size(102, 22);
            this.ImputIva.TabIndex = 16;
            this.ImputIva.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "IVA: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // OutputDescripccion
            // 
            this.OutputDescripccion.AutoSize = true;
            this.OutputDescripccion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDescripccion.Location = new System.Drawing.Point(193, 188);
            this.OutputDescripccion.Name = "OutputDescripccion";
            this.OutputDescripccion.Size = new System.Drawing.Size(106, 24);
            this.OutputDescripccion.TabIndex = 14;
            this.OutputDescripccion.Text = "Descripccion:";
            // 
            // OutputModelo
            // 
            this.OutputModelo.AutoSize = true;
            this.OutputModelo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputModelo.Location = new System.Drawing.Point(193, 122);
            this.OutputModelo.Name = "OutputModelo";
            this.OutputModelo.Size = new System.Drawing.Size(69, 24);
            this.OutputModelo.TabIndex = 13;
            this.OutputModelo.Text = "Modelo:";
            // 
            // OutputPrecio
            // 
            this.OutputPrecio.AutoSize = true;
            this.OutputPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPrecio.Location = new System.Drawing.Point(193, 155);
            this.OutputPrecio.Name = "OutputPrecio";
            this.OutputPrecio.Size = new System.Drawing.Size(60, 24);
            this.OutputPrecio.TabIndex = 12;
            this.OutputPrecio.Text = "Precio:";
            // 
            // OutputMarcar
            // 
            this.OutputMarcar.AutoSize = true;
            this.OutputMarcar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputMarcar.Location = new System.Drawing.Point(193, 88);
            this.OutputMarcar.Name = "OutputMarcar";
            this.OutputMarcar.Size = new System.Drawing.Size(61, 24);
            this.OutputMarcar.TabIndex = 11;
            this.OutputMarcar.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descripccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Modelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Marca:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(756, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refrescar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImputPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImputModelo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImputIva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ImputDescripccion;
        private System.Windows.Forms.NumericUpDown ImputPrecio;
        private System.Windows.Forms.TextBox InputMarca;
        private System.Windows.Forms.NumericUpDown ImputModelo;
        private System.Windows.Forms.Button BtnCargarDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label OutputDescripccion;
        private System.Windows.Forms.Label OutputModelo;
        private System.Windows.Forms.Label OutputPrecio;
        private System.Windows.Forms.Label OutputMarcar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OutputPrecioFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown ImputIva;
    }
}

