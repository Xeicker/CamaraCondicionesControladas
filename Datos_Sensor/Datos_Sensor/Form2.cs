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
        
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            button1.DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public string Valor
        {
            get
            {
                return textBox1.Text;
            }
        }
    }
}
