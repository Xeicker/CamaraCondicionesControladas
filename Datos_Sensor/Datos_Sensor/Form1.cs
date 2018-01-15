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
        List<Panel> paneles_Visibles = new List<Panel>();
        List<ToolStripMenuItem> opciones = new List<ToolStripMenuItem>();
        List<bool> opciones_Seleccionadas = new List<bool>();
        double[] Datos = new double[4]; // presión en Pa, temperatura en m°C, humedad en %, luz en mlux

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
            foreach (ToolStripMenuItem op in verToolStripMenuItem.DropDownItems)
            {
                opciones.Add(op);
                op.Checked = true;
                opciones_Seleccionadas.Add(true);
            }
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
    }
}
