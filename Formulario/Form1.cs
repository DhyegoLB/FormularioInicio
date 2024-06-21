using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class ForInicio : Form
    {
        public ForInicio()
        {
            InitializeComponent();
        }
        DateTime time;
        private void ForInicio_Load(object sender, EventArgs e)
        {
           //Hora do Formulario.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label1.Text = time.ToLongTimeString();  //conometro onde a data e a hora estão dentro da Leibol.
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //data do formulario.
        }
    }
}
