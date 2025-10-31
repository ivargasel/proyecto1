using System;
using System.Windows.Forms;
using Vending_Machine.Application;

namespace VendingMachine
{
    public partial class Payment : Form
    {
        GlobalOperations operations = new GlobalOperations();
        double saldoTarjeta = 0;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblTotal.Text = operations.TotalCompras().ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblPendiente.Text = operations.TotalVuelto().ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblVuelto.Text = "0";// operations.TotalVuelto().ToString("C2", new System.Globalization.CultureInfo("es-cr"));

            bGeneraSaldoAleatorio();
            this.txtEfectivo.KeyPress += new KeyPressEventHandler(this.validaDatoNumerico);
            this.txtTarjeta.KeyPress += new KeyPressEventHandler(this.validaDatoNumerico);
        }

        private void validaDatoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
            double tarjetaIngresado = !string.IsNullOrEmpty(txtTarjeta.Text) ? Convert.ToDouble(txtTarjeta.Text) : 0;
            double totalMontos = tarjetaIngresado + efectivoIngresado;

            lblPendiente.Text = operations.TotalPendiente(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblVuelto.Text = operations.TotalVuelto(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
            double tarjetaIngresado = !string.IsNullOrEmpty(txtTarjeta.Text) ? Convert.ToDouble(txtTarjeta.Text) : 0;
            double totalMontos = tarjetaIngresado + efectivoIngresado;

            if (!bVerificarSaldo(tarjetaIngresado))
            {
                txtTarjeta.Text = "0";
                totalMontos = 0 + efectivoIngresado;
                MessageBox.Show("El saldo de la tarjeta es insuficiente.", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblPendiente.Text = operations.TotalPendiente(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblVuelto.Text = operations.TotalVuelto(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
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
                string productos = string.Empty;
                var ordernes = operations.IndexCompras();
                foreach (var orden in ordernes)
                {
                    productos += $"{orden.Nombre} - {orden.Precio.ToString("C2", new System.Globalization.CultureInfo("es-cr"))} - 1 \n";
                }

                string obj = $"{totalCompra}\n{efectivoIngresado}\n{tarjetaIngresado}\n{totalPagado}\n{productos}\n{DateTime.UtcNow}";

                operations.CreateOrdenes(obj);
                operations.ClearCompras();

                MessageBox.Show("Pago realizado con éxito. ¡Gracias por su compra!", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 main = new Form1();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El monto ingresado es insuficiente para completar la compra. Por favor, ingrese un monto válido.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            Form1 vendingMachine = new Form1();
            vendingMachine.Show();
            this.Hide();
        }

        private void bGeneraSaldoAleatorio()
        {
            Random rnd = new Random();
            double saldoAleatorio = rnd.Next(0, 1000); // Asigna un número en el rango asignado
            saldoTarjeta = saldoAleatorio;
        }

        private bool bVerificarSaldo(double tarjetaIngresado)
        {
            if(tarjetaIngresado > saldoTarjeta)
                 return false;
            return true;
        }

    }
}
