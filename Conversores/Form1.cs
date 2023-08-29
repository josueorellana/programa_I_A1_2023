using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores
{
    public partial class Conversor : Form
    {

        String[][] tiposConversores = new string[][]{
            new string[] {"Hectareas", "Metro cuadrado", "Pie cuadrado", "Yarda cuadrada", "Vara cuadrada", "Tareas", "Manzanas"}, //MEDIDAS
        };

        public Conversor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertirConversor_Click(object sender, EventArgs e)


        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversor.SelectedIndex;
            a = cboAConversor.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversor.Text);
          
            double[][] area = {
            new double[]{ 1, 10000, 107639, 11959.9, 14285.71, 15.90330789, 1.4196479273}, 
        };
            respuesta = area[cboTipoConversor.SelectedIndex][a] / area[cboTipoConversor.SelectedIndex][de] * cantidad;
            lblRespuestaConversor.Text = "Respuesta: " + Math.Round(respuesta, 3);


        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCantidadConversor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRespuestaConversor_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboAConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAConversor_Click(object sender, EventArgs e)
        {

        }

        private void cboDeConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDeConversor_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoConversor_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloConversor_Click(object sender, EventArgs e)
        {

        }
    }
}
