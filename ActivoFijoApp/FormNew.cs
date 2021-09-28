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
using Domain;

namespace ActivoFijoApp
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }
        ActivoModel activo;
        public FormNew(ActivoModel a)
        {
            activo = new ActivoModel();
            InitializeComponent();
            activo = a;
        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormNew_Load(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActivoFijo a = new ActivoFijo { ID = (int)numericUpDown1.Value,
            Codigo=textBox1.Text, Nombre=textBox2.Text, Descripcion=textBox3.Text, ValorActivo=numericUpDown2.Value, ValorReesidual=numericUpDown3.Value, VidaUtil = (int)numericUpDown4.Value,
            FechaAdquicision=dateTimePicker1.Value,TipoActivo=(TipoActivo)comboBox1.SelectedIndex, metodoDepreciacion=(MetodoDepreciacion)comboBox2.SelectedIndex};
            activo.Add(a);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
