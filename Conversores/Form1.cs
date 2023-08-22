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
            new string[] {"Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "Colon SV", "Colon CR", "Yenes", "Rupias Indias", "Libras Esterlinas" }, // Moneda
            new string[]{"Libras", "Miligramos", "Gramos", "Onzas", "Tonelada Corta", "Kilogramos", "Tonelada Métrica", "Stone", "Kilonewton" }, // Masa
            new string[]{"Litro", "Mililitro", "Metro Cubico", "Pie Cubico", "Pulgada Cubica", "Galón Imperial", "Galón de EE. UU.", "Metro Cúbico de Gas", "Pie Cúbico de Gas" }, // Volumen
            new string[]{"Metro", "Milimetro", "Centimetro", "Pulgada", "Pies", "Varas", "Yardas", "Kilometros", "Millas", "Nanometros" }, // Longitud
            new string[]{"Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte"}, // almacenamiento
            new string[]{"Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes", "Año", "Decada"}, // Tiempo
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
            // Dolar, Euro, Quetzal, Lempira, Cordova, Colon SV, Colon CR, Yenes, Rupias India, Libras Esterlinas
            double[][] monedas = {
            new double[]{ 1, 0.92, 7.86, 24.62, 36.57, 8.74, 532.83, 146.25, 83.11, 0.78 }, // Moneda
            new double[]{ 1, 453592, 453.59, 16, 0.0005, 0.453592, 0.000453592, 0.0714286, 0.0044 }, // Masa 
            new double[]{ 1, 1000, 0.001, 0.0353147, 61.0237, 0.219969, 0.264172, 0.001, 28.3168 }, // Volumen 
            new double[]{ 1, 1000, 100, 39.3701, 3.28084, 1.1963081929167, 1.0936, 0.001, 0.000621371, 1000000000 }, // Longitud
            new double[]{ 1, 0.125,0.0001220703125, 1.1920928955078e-7, 1.1641532182693e-10, 1.1368683772162e-13, 1.1102230246252e-16, 1.0842021724855e-19, 1.0587911840679e-22, 1.0339757656913e-25 }, // Almacenamiento
            new double[]{ 1, 0.002, 0.000001, 60000000, 3600000000, 86400000000, 604800000000, 2628000000000, 31536000000000, 315360000000000 }, // Tiempo
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
