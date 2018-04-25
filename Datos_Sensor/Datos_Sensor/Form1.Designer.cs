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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearArchivoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_RB_P = new System.Windows.Forms.TextBox();
            this.cB_P = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_RA_P = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tB_RA_T = new System.Windows.Forms.TextBox();
            this.tB_RB_T = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.cB_T = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_RA_H = new System.Windows.Forms.TextBox();
            this.tB_RB_H = new System.Windows.Forms.TextBox();
            this.cB_H = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLuz = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_RA_L = new System.Windows.Forms.TextBox();
            this.tB_RB_L = new System.Windows.Forms.TextBox();
            this.cB_L = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spXDK = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_RA_R = new System.Windows.Forms.TextBox();
            this.tB_RB_R = new System.Windows.Forms.TextBox();
            this.cB_R = new System.Windows.Forms.ComboBox();
            this.lblRuido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.P_Control = new System.Windows.Forms.Panel();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.P_Control.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.puertoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearArchivoDeDatosToolStripMenuItem,
            this.actualizarToolStripMenuItem,
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
            this.crearArchivoDeDatosToolStripMenuItem.Click += new System.EventHandler(this.crearArchivoDeDatosToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puertosToolStripMenuItem,
            this.toolStripSeparator1});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.actualizarToolStripMenuItem.Text = "Seleccionar puerto";
            this.actualizarToolStripMenuItem.MouseEnter += new System.EventHandler(this.actualizarToolStripMenuItem_MouseEnter);
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.Enabled = false;
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.puertosToolStripMenuItem.Text = "Puertos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
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
            this.luminocidadToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // presionToolStripMenuItem
            // 
            this.presionToolStripMenuItem.CheckOnClick = true;
            this.presionToolStripMenuItem.Name = "presionToolStripMenuItem";
            this.presionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presionToolStripMenuItem.Text = "Presion";
            this.presionToolStripMenuItem.Click += new System.EventHandler(this.presionToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.CheckOnClick = true;
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // ruidoToolStripMenuItem
            // 
            this.ruidoToolStripMenuItem.CheckOnClick = true;
            this.ruidoToolStripMenuItem.Name = "ruidoToolStripMenuItem";
            this.ruidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ruidoToolStripMenuItem.Text = "Ruido";
            this.ruidoToolStripMenuItem.Click += new System.EventHandler(this.ruidoToolStripMenuItem_Click);
            // 
            // luminocidadToolStripMenuItem
            // 
            this.luminocidadToolStripMenuItem.CheckOnClick = true;
            this.luminocidadToolStripMenuItem.Name = "luminocidadToolStripMenuItem";
            this.luminocidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luminocidadToolStripMenuItem.Text = "Luminocidad";
            this.luminocidadToolStripMenuItem.Click += new System.EventHandler(this.luminocidadToolStripMenuItem_Click);
            // 
            // puertoToolStripMenuItem
            // 
            this.puertoToolStripMenuItem.Enabled = false;
            this.puertoToolStripMenuItem.Name = "puertoToolStripMenuItem";
            this.puertoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.puertoToolStripMenuItem.Text = "Puerto: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tB_RB_P);
            this.panel1.Controls.Add(this.cB_P);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tB_RA_P);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblPresion);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 220);
            this.panel1.TabIndex = 1;
            // 
            // tB_RB_P
            // 
            this.tB_RB_P.Location = new System.Drawing.Point(15, 140);
            this.tB_RB_P.Name = "tB_RB_P";
            this.tB_RB_P.Size = new System.Drawing.Size(69, 20);
            this.tB_RB_P.TabIndex = 2;
            this.tB_RB_P.Text = "40";
            this.tB_RB_P.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RB_P.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cB_P
            // 
            this.cB_P.FormattingEnabled = true;
            this.cB_P.Items.AddRange(new object[] {
            "mmHg",
            "Pa",
            "kPa",
            "bar",
            "atm"});
            this.cB_P.Location = new System.Drawing.Point(15, 186);
            this.cB_P.Name = "cB_P";
            this.cB_P.Size = new System.Drawing.Size(69, 21);
            this.cB_P.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CadetBlue;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Presión";
            // 
            // tB_RA_P
            // 
            this.tB_RA_P.Location = new System.Drawing.Point(15, 86);
            this.tB_RA_P.Name = "tB_RA_P";
            this.tB_RA_P.Size = new System.Drawing.Size(69, 20);
            this.tB_RA_P.TabIndex = 1;
            this.tB_RA_P.Text = "100";
            this.tB_RA_P.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RA_P.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 158);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rango\r\nMax:\r\n\r\n\r\n\r\nMin:\r\n\r\n\r\n\r\nUnidades:";
            // 
            // lblPresion
            // 
            this.lblPresion.BackColor = System.Drawing.Color.LimeGreen;
            this.lblPresion.Location = new System.Drawing.Point(97, 56);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(51, 160);
            this.lblPresion.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.tB_RA_T);
            this.panel2.Controls.Add(this.tB_RB_T);
            this.panel2.Controls.Add(this.lblTemperatura);
            this.panel2.Controls.Add(this.cB_T);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(173, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 220);
            this.panel2.TabIndex = 2;
            // 
            // tB_RA_T
            // 
            this.tB_RA_T.Location = new System.Drawing.Point(14, 86);
            this.tB_RA_T.Name = "tB_RA_T";
            this.tB_RA_T.Size = new System.Drawing.Size(69, 20);
            this.tB_RA_T.TabIndex = 10;
            this.tB_RA_T.Text = "40";
            this.tB_RA_T.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RA_T.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tB_RB_T
            // 
            this.tB_RB_T.Location = new System.Drawing.Point(14, 140);
            this.tB_RB_T.Name = "tB_RB_T";
            this.tB_RB_T.Size = new System.Drawing.Size(69, 20);
            this.tB_RB_T.TabIndex = 11;
            this.tB_RB_T.Text = "10";
            this.tB_RB_T.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RB_T.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTemperatura.Location = new System.Drawing.Point(97, 56);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(51, 160);
            this.lblTemperatura.TabIndex = 0;
            // 
            // cB_T
            // 
            this.cB_T.FormattingEnabled = true;
            this.cB_T.Items.AddRange(new object[] {
            "°C",
            "°F",
            "K"});
            this.cB_T.Location = new System.Drawing.Point(14, 186);
            this.cB_T.Name = "cB_T";
            this.cB_T.Size = new System.Drawing.Size(69, 21);
            this.cB_T.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "Temperatura";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 158);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rango\r\nMax:\r\n\r\n\r\n\r\nMin:\r\n\r\n\r\n\r\nUnidades:";
            // 
            // lblHumedad
            // 
            this.lblHumedad.BackColor = System.Drawing.Color.LimeGreen;
            this.lblHumedad.Location = new System.Drawing.Point(97, 56);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(51, 160);
            this.lblHumedad.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tB_RA_H);
            this.panel3.Controls.Add(this.tB_RB_H);
            this.panel3.Controls.Add(this.cB_H);
            this.panel3.Controls.Add(this.lblHumedad);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(334, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 220);
            this.panel3.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 39);
            this.label11.TabIndex = 19;
            this.label11.Text = "Humedad";
            // 
            // tB_RA_H
            // 
            this.tB_RA_H.Location = new System.Drawing.Point(14, 86);
            this.tB_RA_H.Name = "tB_RA_H";
            this.tB_RA_H.Size = new System.Drawing.Size(69, 20);
            this.tB_RA_H.TabIndex = 15;
            this.tB_RA_H.Text = "100";
            this.tB_RA_H.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RA_H.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tB_RB_H
            // 
            this.tB_RB_H.Location = new System.Drawing.Point(14, 140);
            this.tB_RB_H.Name = "tB_RB_H";
            this.tB_RB_H.Size = new System.Drawing.Size(69, 20);
            this.tB_RB_H.TabIndex = 16;
            this.tB_RB_H.Text = "50";
            this.tB_RB_H.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RB_H.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cB_H
            // 
            this.cB_H.FormattingEnabled = true;
            this.cB_H.Items.AddRange(new object[] {
            "%"});
            this.cB_H.Location = new System.Drawing.Point(14, 186);
            this.cB_H.Name = "cB_H";
            this.cB_H.Size = new System.Drawing.Size(69, 21);
            this.cB_H.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 158);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rango\r\nMax:\r\n\r\n\r\n\r\nMin:\r\n\r\n\r\n\r\nUnidades:";
            // 
            // lblLuz
            // 
            this.lblLuz.BackColor = System.Drawing.Color.LimeGreen;
            this.lblLuz.Location = new System.Drawing.Point(96, 57);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(51, 160);
            this.lblLuz.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.tB_RA_L);
            this.panel4.Controls.Add(this.tB_RB_L);
            this.panel4.Controls.Add(this.cB_L);
            this.panel4.Controls.Add(this.lblLuz);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(653, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 220);
            this.panel4.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.CadetBlue;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 39);
            this.label12.TabIndex = 25;
            this.label12.Text = "Luminosidad";
            // 
            // tB_RA_L
            // 
            this.tB_RA_L.Location = new System.Drawing.Point(13, 84);
            this.tB_RA_L.Name = "tB_RA_L";
            this.tB_RA_L.Size = new System.Drawing.Size(69, 20);
            this.tB_RA_L.TabIndex = 21;
            this.tB_RA_L.Text = "100";
            this.tB_RA_L.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RA_L.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tB_RB_L
            // 
            this.tB_RB_L.Location = new System.Drawing.Point(13, 141);
            this.tB_RB_L.Name = "tB_RB_L";
            this.tB_RB_L.Size = new System.Drawing.Size(69, 20);
            this.tB_RB_L.TabIndex = 22;
            this.tB_RB_L.Text = "0";
            this.tB_RB_L.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_RA_P_KeyDown);
            this.tB_RB_L.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cB_L
            // 
            this.cB_L.FormattingEnabled = true;
            this.cB_L.Items.AddRange(new object[] {
            "mLux",
            "Lux"});
            this.cB_L.Location = new System.Drawing.Point(13, 187);
            this.cB_L.Name = "cB_L";
            this.cB_L.Size = new System.Drawing.Size(69, 21);
            this.cB_L.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 158);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rango\r\nMax:\r\n\r\n\r\n\r\nMin:\r\n\r\n\r\n\r\nUnidades:";
            // 
            // spXDK
            // 
            this.spXDK.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spXDK_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.tB_RA_R);
            this.panel5.Controls.Add(this.tB_RB_R);
            this.panel5.Controls.Add(this.cB_R);
            this.panel5.Controls.Add(this.lblRuido);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(493, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 220);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 39);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ruido";
            // 
            // tB_RA_R
            // 
            this.tB_RA_R.Location = new System.Drawing.Point(13, 84);
            this.tB_RA_R.Name = "tB_RA_R";
            this.tB_RA_R.Size = new System.Drawing.Size(69, 20);
            this.tB_RA_R.TabIndex = 21;
            this.tB_RA_R.Text = "100";
            // 
            // tB_RB_R
            // 
            this.tB_RB_R.Location = new System.Drawing.Point(13, 141);
            this.tB_RB_R.Name = "tB_RB_R";
            this.tB_RB_R.Size = new System.Drawing.Size(69, 20);
            this.tB_RB_R.TabIndex = 22;
            this.tB_RB_R.Text = "40";
            // 
            // cB_R
            // 
            this.cB_R.FormattingEnabled = true;
            this.cB_R.Items.AddRange(new object[] {
            "mdB",
            "dB"});
            this.cB_R.Location = new System.Drawing.Point(13, 187);
            this.cB_R.Name = "cB_R";
            this.cB_R.Size = new System.Drawing.Size(69, 21);
            this.cB_R.TabIndex = 24;
            // 
            // lblRuido
            // 
            this.lblRuido.BackColor = System.Drawing.Color.LimeGreen;
            this.lblRuido.Location = new System.Drawing.Point(97, 57);
            this.lblRuido.Name = "lblRuido";
            this.lblRuido.Size = new System.Drawing.Size(51, 160);
            this.lblRuido.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 158);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rango\r\nMax:\r\n\r\n\r\n\r\nMin:\r\n\r\n\r\n\r\nUnidades:";
            // 
            // P_Control
            // 
            this.P_Control.BackColor = System.Drawing.Color.Snow;
            this.P_Control.Controls.Add(this.label13);
            this.P_Control.Controls.Add(this.label10);
            this.P_Control.Controls.Add(this.label5);
            this.P_Control.Controls.Add(this.panel6);
            this.P_Control.Controls.Add(this.button5);
            this.P_Control.Controls.Add(this.button4);
            this.P_Control.Controls.Add(this.button3);
            this.P_Control.Controls.Add(this.button2);
            this.P_Control.Controls.Add(this.button1);
            this.P_Control.Location = new System.Drawing.Point(814, 28);
            this.P_Control.Name = "P_Control";
            this.P_Control.Size = new System.Drawing.Size(200, 220);
            this.P_Control.TabIndex = 6;
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(73, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "ON\r\n\r\nOFF";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(23, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(23, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(154, 121);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "^";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(154, 169);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "v";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(23, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 83);
            this.panel6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "MODE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "FAN SPEED";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(152, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "TMP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "AUTO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "LOW";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "23°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1020, 255);
            this.Controls.Add(this.P_Control);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "XDK ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.P_Control.ResumeLayout(false);
            this.P_Control.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tB_RB_P;
        private System.Windows.Forms.TextBox tB_RA_P;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cB_P;
        private System.IO.Ports.SerialPort spXDK;
        private System.Windows.Forms.TextBox tB_RA_T;
        private System.Windows.Forms.TextBox tB_RB_T;
        private System.Windows.Forms.ComboBox cB_T;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_RA_H;
        private System.Windows.Forms.TextBox tB_RB_H;
        private System.Windows.Forms.ComboBox cB_H;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tB_RA_L;
        private System.Windows.Forms.TextBox tB_RB_L;
        private System.Windows.Forms.ComboBox cB_L;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem puertoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_RA_R;
        private System.Windows.Forms.TextBox tB_RB_R;
        private System.Windows.Forms.ComboBox cB_R;
        private System.Windows.Forms.Label lblRuido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.Panel P_Control;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}