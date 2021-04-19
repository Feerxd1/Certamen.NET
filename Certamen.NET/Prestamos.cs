using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certamen.NET
{
    public partial class Prestamos : Form
    {

        string nombre_cliente;
        int[] cuotas_disponibles = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        Dictionary<int, double> intereses_base;


        public Prestamos(string txtnombre)
        {
            InitializeComponent();

            nombre_cliente = txtnombre;

            intereses_base = new Dictionary<int, double>();

            double interes;

            int i;

            for (i = 0, interes = 10.0; i < cuotas_disponibles.Length; i++, interes += 0.0)

            {
                intereses_base[cuotas_disponibles[i]] = interes;
            }

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            popularCuotas();
            saludo.Text += nombre_cliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                cuotascombo.Items.Add(cuotas_disponibles[i]);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotas_pedidas = (int)cuotascombo.SelectedItem;
            double interes = intereses_base[cuotas_pedidas];

            return interes;
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            Double interes_mensual = calcularInteres();
            Double monto_pedido = double.Parse(monto.Text);
            int cuotas_pedidas = (int)cuotascombo.SelectedItem;
            double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
            double monto_a_pagar = monto_pedido + interes_total;
            string mensaje = "Su prestamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas se concedera con un interes del " + interes_mensual + " % mensual \nEl monto final asciende a " + monto_a_pagar;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(mensaje, "calculo de interes", buttons);
            
        }

        private void monto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


                

