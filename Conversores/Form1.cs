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
            new String[] {"Dolar", "Quetzal", "Lempira", "Cordoba", "Colon SV", "Colon CR", "Yenes", "Rupias Indias", "Libras Esterlinas" }, // Moneda
            new String[]{"Libras", "Miligramos", "Gramos", "Onzas", "Tonelada Corta" }, // Masa
            new String[]{"Litro" }, // Volumen
            new String[]{"Metro", "Milimetro", "Centimetro", "Pulgada", "Pies", "Varas", "Yardas", "Kilometros", "Millas" }// Longitud
            // Matriz multidimencional
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
            // Dolar, Euro, Quetzal, Lempira, Cordova, Colon SV, Colon CR, Yenes, Rupias India, Libras Esterlinas
            double[][] monedas = {
                new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79 },// Array Unidimencional
                new double[] { }, // Masa
                new double[] { }, // Masa
                new double[] { 1, 1000, 100, 39.3701, 3.28084, 1.1963081929167, 1.0936, 0.001, 0.000621371 } // Longitud
        };
            respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
            lblRespuestaConversor.Text = "Respueta: " + Math.Round(respuesta, 3);

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
    }
}
