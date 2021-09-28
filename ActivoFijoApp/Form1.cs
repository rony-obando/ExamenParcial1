using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infraestructura;

namespace ActivoFijoApp
{
    public partial class Form1 : Form
    {
        ActivoModel activo;
        public Form1()
        {
            activo = new ActivoModel();
            InitializeComponent();
        }
        public void mostrar()
        {

        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            
            FormNew form = new FormNew(activo);
            form.ShowDialog();
            richTextBox1.Text = activo.mostrar();
        }
    }
}
