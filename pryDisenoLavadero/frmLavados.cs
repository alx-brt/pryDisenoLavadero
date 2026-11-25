using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoLavadero
{
    public partial class frmLavados : Form
    {
        private decimal recargo;
        private decimal total;
        private int cantidad;

        public frmLavados()
        {
            InitializeComponent();
        }



        private void txtVehiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad;

            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.");
                txtCliente.Focus();
                return;
            }

            if (txtPatente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la patente del vehículo.");
                txtPatente.Focus();
                return;
            }

            if (cboServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                cboServicio.Focus();
                return;
            }

            if (!int.TryParse(txtVehiculos.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida de vehículos.");
                txtVehiculos.Focus();
                return;
            }

            if (cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("La cantidad de vehículos debe estar entre 1 y 5.");
                txtVehiculos.Focus();
                return;
            }

            if (!rbnNormal.Checked && !rbnExpress.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de lavado.");
                return;
            }



            decimal precio = 0m;

            switch (cboServicio.SelectedIndex)
            {
                case 0:
                    precio = 8000m;
                    break;
                case 1:
                    precio = 14000m;
                    break;
                case 2:
                    precio = 20000m;
                    break;
                default:
                    precio = 0m;
                    break;
            }



            decimal subtotal = precio * cantidad;


            recargo = 0m;
            if (rbnExpress.Checked)
            {
                recargo = subtotal * 25 / 100m;
            }


            int porcentaje = 0;

            if (cantidad >= 4)
            {
                porcentaje = 15;
            }
            else if (cantidad >= 2)
            {
                porcentaje = 10;
            }
            else
            {
                porcentaje = 0;
            }

            if (chkClienteFrecuente.Checked)
            {
                porcentaje += 5;
            }


            decimal descuento = subtotal * porcentaje / 100m;


            total = subtotal + recargo - descuento;



            lblMostrarSubtotal.Text = "$" + subtotal.ToString("N2");
            lblMostrarRecargo.Text = "$" + recargo.ToString("N2");
            lblMostrarDescuento.Text = "$" + descuento.ToString("N2");
            lblMostrarTotal.Text = "$" + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtPatente.Clear();
            txtVehiculos.Clear();
            cboServicio.SelectedIndex = -1;
            rbnNormal.Checked = false;
            rbnExpress.Checked = false;
            chkClienteFrecuente.Checked = false;
            lblMostrarSubtotal.Text = "$0.00";
            lblMostrarRecargo.Text = "$0.00";
            lblMostrarDescuento.Text = "$0.00";
            lblMostrarTotal.Text = "$0.00";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvLavados.Rows.Add(
                txtCliente.Text,
                txtPatente.Text,
                cboServicio.Text,
                txtVehiculos.Text,
                rbnExpress.Checked ? "Express" : "Normal",
                chkClienteFrecuente.Checked ? "Sí" : "No",
                recargo.ToString("N2"),
                total.ToString("N2")
            );
        }
    }
}
