namespace Datos_Sensor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearArchivoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearArchivoDeDatosToolStripMenuItem,
            this.salitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearArchivoDeDatosToolStripMenuItem
            // 
            this.crearArchivoDeDatosToolStripMenuItem.Name = "crearArchivoDeDatosToolStripMenuItem";
            this.crearArchivoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.crearArchivoDeDatosToolStripMenuItem.Text = "Crear archivo de datos";
            // 
            // salitToolStripMenuItem
            // 
            this.salitToolStripMenuItem.Name = "salitToolStripMenuItem";
            this.salitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salitToolStripMenuItem.Text = "Salir";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presionToolStripMenuItem,
            this.temperaturaToolStripMenuItem,
            this.ruidoToolStripMenuItem,
            this.luminocidadToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // presionToolStripMenuItem
            // 
            this.presionToolStripMenuItem.CheckOnClick = true;
            this.presionToolStripMenuItem.Name = "presionToolStripMenuItem";
            this.presionToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.presionToolStripMenuItem.Text = "Presion";
            this.presionToolStripMenuItem.Click += new System.EventHandler(this.presionToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.CheckOnClick = true;
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // ruidoToolStripMenuItem
            // 
            this.ruidoToolStripMenuItem.CheckOnClick = true;
            this.ruidoToolStripMenuItem.Name = "ruidoToolStripMenuItem";
            this.ruidoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ruidoToolStripMenuItem.Text = "Ruido";
            this.ruidoToolStripMenuItem.Click += new System.EventHandler(this.ruidoToolStripMenuItem_Click);
            // 
            // luminocidadToolStripMenuItem
            // 
            this.luminocidadToolStripMenuItem.CheckOnClick = true;
            this.luminocidadToolStripMenuItem.Name = "luminocidadToolStripMenuItem";
            this.luminocidadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.luminocidadToolStripMenuItem.Text = "Luminocidad";
            this.luminocidadToolStripMenuItem.Click += new System.EventHandler(this.luminocidadToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 220);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(3, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 100);
            this.panel5.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 100);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rango\r\nMax:\r\n\r\n\r\nMin:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "100%";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(97, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 145);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 145);
            this.label5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(173, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 220);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 196);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 196);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(316, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 220);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 196);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(465, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 220);
            this.panel4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(32, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(32, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(620, 261);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearArchivoDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminocidadToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

