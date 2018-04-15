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
    public partial class Form2 : Form
    {
        Dictionary<string,string[]> Cb= new Dictionary<string,string[]>();
        string[] Seg = { "3","9","30" };
        string[] Min = { "1", "2", "5","10","20","30" };
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            button1.DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cb.Add("Min",Min);
            Cb.Add("Seg", Seg);
            comboBox2.SelectedIndex = 0;
            comboBox1.DataSource = Seg;
        }
        public string[] Valor
        {
            get
            {
                string[] v = { comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString() };
                return v;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = Cb[comboBox2.SelectedItem.ToString()];
        }
    }
}
