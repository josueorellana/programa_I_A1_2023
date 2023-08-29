using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// integrantes del equipo

// Wilbert José Girón Pérez
// Josue David Morales Orellana
namespace Conversores
{
    public partial class Conversor : Form
    {

        String[][] tiposConversores = new string[][]{
            new string[] {"pie ciadrado", "vara cuadrada", "metro cuadrado", "tareas", "manzanas", "hectareas" }, // areas

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
            // pie ciadrado, vara cuadrada, metro cuadrado, tareas, manzanas, hectareas
            double[][] monedas = {
            new double[]{ 1, 0.111111, 0.092903, 0.00014774656489, 0.00001317, 9.29368029739777,}, // area
        };
            respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
            lblRespuestaConversor.Text = "Respuesta: " + Math.Round(respuesta, 3);



        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {

            cboDeConversor.Items.Clear();
            cboDeConversor.Items.AddRange(tiposConversores[cboTipoConversor.SelectedIndex]);

            cboAConversor.Items.Clear();
            cboAConversor.Items.AddRange(tiposConversores[cboTipoConversor.SelectedIndex]);
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
