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
    public partial class caja : Form
    {
        public caja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(txtnombre.Text))
                ventanaPrestamos.ShowDialog();
        }

        private void txtcantidadcuotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void botonsimular_Load(object sender, EventArgs e)
        {
            botonsimular.Enabled = false;
        }

        private void txtcuota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidadcredito_TextChanged(object sender, EventArgs e)
        {

        }


        private void ControlBotones()
        {
            if (txtapellido.Text.Trim() != string.Empty && txtapellido.Text.All(Char.IsLetter))
            {
                botonsimular.Enabled = true;
                errorProvider1.SetError(txtapellido, "");
            }

            else

            {
                if (!(txtapellido.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtapellido, "El Apellido solo puede contener letras");
                }

                else

                {
                    errorProvider1.SetError(txtapellido, "Debe introducir un Apellido");
                }
                botonsimular.Enabled = false;
                txtapellido.Focus();
            }
        }





        private void ControlBotones1()
        {
            if (txtnombre.Text.Trim() != string.Empty && txtnombre.Text.All(Char.IsLetter))
            {
                botonsimular.Enabled = true;
                errorProvider1.SetError(txtnombre, "");
            }

            else

            {
                if (!(txtnombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtnombre, "El nombre solo puede contener letras");
                }

                else

                {
                    errorProvider1.SetError(txtnombre, "Debe introducir un nombre");
                }
                botonsimular.Enabled = false;
                txtnombre.Focus();
            }
        }




        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            
            ControlBotones1();
            
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            ControlBotones();
        }
    }
}
