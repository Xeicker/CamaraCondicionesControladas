using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Datos_Sensor
{
    public partial class Form1 : Form
    {
        List<Panel> paneles = new List<Panel>();
        List<Label> labels = new List<Label>();
        List<ComboBox> CBox = new List<ComboBox>();

        List<Panel> paneles_Visibles = new List<Panel>();
        List<ToolStripMenuItem> opciones = new List<ToolStripMenuItem>();
        List<bool> opciones_Seleccionadas = new List<bool>();
        Random rd = new Random();
        double[] Limites = { 100, 70, 40, 20, 100, 50, 100, 0 };
        Dictionary<string, int> Limites_StoI = new Dictionary<string, int>();
        Dictionary<string, double> Factores = new Dictionary<string, double>();
        double[] Datos = { 80, 25, 67, 10 };// new double[4]; // presión en Pa, temperatura en m°C, humedad en %, luz en mlux

        public Form1()
        {
            InitializeComponent();
            //cbPuertosSeriales.DataSource = SerialPort.GetPortNames();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paneles.Add(panel1);
            paneles.Add(panel2);
            paneles.Add(panel3);
            paneles.Add(panel4);
            labels.Add(lblPresion);
            labels.Add(lblTemperatura);
            labels.Add(lblHumedad);
            labels.Add(lblLuz);
            CBox.Add(cB_P);
            CBox.Add(cB_T);
            CBox.Add(cB_H);
            CBox.Add(cB_L);
            cB_P.SelectedIndex = 0;
            foreach (ToolStripMenuItem op in verToolStripMenuItem.DropDownItems)
            {
                opciones.Add(op);
                op.Checked = true;
                opciones_Seleccionadas.Add(true);
            }
            Limites_StoI.Add("tB_RA_P", 0);
            Limites_StoI.Add("tB_RB_P", 1);
            Limites_StoI.Add("tB_RA_T", 2);
            Limites_StoI.Add("tB_RB_T", 3);
            Limites_StoI.Add("tB_RA_H", 4);
            Limites_StoI.Add("tB_RB_H", 5);
            Limites_StoI.Add("tB_RA_L", 6);
            Limites_StoI.Add("tB_RB_L", 7);
            Factores.Add("Pa", 1);
            Factores.Add("kPa", 0.001);
            Factores.Add("mmHg", 0.0075006375541921);
            Factores.Add("bar", 0.00001);
            Factores.Add("atm", 0.0000098692);

        }

        private void presionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opciones_Seleccionadas[0] = !opciones_Seleccionadas[0];
            Actualizar_Paneles();
        }
        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opciones_Seleccionadas[1] = !opciones_Seleccionadas[1];
            Actualizar_Paneles();
        }
        private void spXDK_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Datos=spXDK.ReadLine().Split('|'); //error
            //se obtienen los datos del puerto serial y se guardan en Datos
            Datos=Array.ConvertAll(spXDK.ReadLine().Split('|'), Double.Parse);
            //Se muestran los datos en sus respectivas labels
            lblPresion.Text = Datos[0] +" Pa";
            lblTemperatura.Text = Datos[1]/1000 + " °C";
            lblHumedad.Text = Datos[2] + " %";
            lblLuz.Text = Datos[3]/1000 + " lux";
        }
        private void ruidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opciones_Seleccionadas[2] = !opciones_Seleccionadas[2];
            Actualizar_Paneles();
        }
        private void luminocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opciones_Seleccionadas[3] = !opciones_Seleccionadas[3];
            Actualizar_Paneles();
        }
        void Actualizar_Paneles()
        {
            int posicion = 10;
            for(int i = 0; i<paneles.Count; i++)
            {
                if (opciones_Seleccionadas[i])
                {
                    paneles[i].Visible = true;
                    paneles[i].Location = new System.Drawing.Point(posicion, paneles[i].Location.Y);
                    posicion += 164;
                }
                else
                    paneles[i].Visible = false;
            }
        }
        void Actualizar_Labels()
        {
            for(int i = 0; i <labels.Count; i++)
            {
                if(Datos[i]>= Limites[i*2+1] && Datos[i]<= Limites[i * 2])
                    labels[i].Size = new System.Drawing.Size(51,(int)((Datos[i]-Limites[i*2+1])/(Limites[i * 2]- Limites[i * 2 + 1])*150)+10);
                else if(Datos[i] > Limites[i * 2])
                    labels[i].Size = new System.Drawing.Size(51, 160);
                else
                    labels[i].Size = new System.Drawing.Size(51, 10);
                labels[i].Location = new System.Drawing.Point(97, 56 + 160 - labels[i].Size.Height);
                labels[i].Text = Datos[i].ToString("N");
            }
        } 
        private void item_Click(object sender, EventArgs e)
        {
            string p = sender.ToString();
            puertoToolStripMenuItem.Text = "Puerto: " + p;
            spXDK.PortName = p;
            //if(!spXDK.IsOpen)
                //spXDK.Open();
        }
        private void actualizarToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

            string[] items = {"COM1","COM2" };//SerialPort.GetPortNames();
            while (actualizarToolStripMenuItem.DropDownItems.Count > 2)
            {
                actualizarToolStripMenuItem.DropDownItems.RemoveAt(2);
            }
            foreach (string item in items)
            {
                actualizarToolStripMenuItem.DropDownItems.Add(item);
            }
            for(int i = 0; i<actualizarToolStripMenuItem.DropDownItems.Count; i++)
            {
                if(i!=1)
                    actualizarToolStripMenuItem.DropDownItems[i].Click += new EventHandler(item_Click);
            }
        }    
        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tbAux = (TextBox)sender;
            try
            {
                Limites[Limites_StoI[tbAux.Name]] = Convert.ToDouble(tbAux.Text)*Factores[CBox[Limites_StoI[tbAux.Name] / 2].SelectedItem.ToString()];
            }
            catch (FormatException)
            {
                tbAux.Text = "";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Datos[0] = rd.NextDouble()*100;
            Datos[1] = (rd.NextDouble()-0.2)*50;
            Datos[2] = rd.NextDouble()*100;
            Datos[3] = rd.NextDouble()*100;
            Actualizar_Labels();
        }
    }
}
