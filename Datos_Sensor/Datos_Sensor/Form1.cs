using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Sensor
{
    public partial class Form1 : Form
    {
        List<Panel> paneles = new List<Panel>();
        List<Panel> paneles_Visibles = new List<Panel>();
        List<ToolStripMenuItem> opciones = new List<ToolStripMenuItem>();
        List<bool> opciones_Seleccionadas = new List<bool>();
        public Form1()
        {
            InitializeComponent();
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
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
                label9.Text = f.Valor;
            int posicion = 10;
            for(int i = 0; i<paneles.Count; i++)
            {
                if (opciones_Seleccionadas[i])
                {
                    paneles[i].Visible = true;
                    paneles[i].Location = new System.Drawing.Point(posicion, paneles[i].Location.Y);
                    posicion += 160;
                }
                else
                    paneles[i].Visible = false;
            }
        }
        
    }
}
