using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vending_Machine.Application;

namespace VendingMachine
{
    public partial class Payment : Form
    {
        GlobalOperations operations = new GlobalOperations();

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblTotal.Text = operations.TotalCompras().ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblVuelto.Text = operations.TotalVuelto().ToString("C2", new System.Globalization.CultureInfo("es-cr"));
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEfectivo.Text))
            {
                double efectivoIngresado = Convert.ToDouble(txtEfectivo.Text);
                lblVuelto.Text = operations.TotalVuelto(efectivoIngresado).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            }            
        }

        private void bPay_Click(object sender, EventArgs e)
        {
            double totalCompra = operations.TotalCompras(); 
            double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
            double tarjetaIngresado = !string.IsNullOrEmpty(txtTarjeta.Text) ? Convert.ToDouble(txtTarjeta.Text) : 0;

            double totalPagado = totalCompra - (efectivoIngresado + tarjetaIngresado);

            if (totalPagado < 0)
            {
                MessageBox.Show("Pago realizado con éxito, tome su vuelto. ¡Gracias por su compra!", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }                                   
            else if (totalPagado == 0)
            {
                MessageBox.Show("Pago realizado con éxito. ¡Gracias por su compra!", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El monto ingresado es insuficiente para completar la compra. Por favor, ingrese un monto válido.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTarjeta.Text))
            {
                double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
                double tarjetaIngresado = Convert.ToDouble(txtTarjeta.Text) + efectivoIngresado;
                lblVuelto.Text = operations.TotalVuelto(tarjetaIngresado).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
