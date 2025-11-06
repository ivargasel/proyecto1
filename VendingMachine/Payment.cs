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
            lblVuelto.Text = "0";

            bGeneraSaldoAleatorio();
            this.txtEfectivo.KeyPress += new KeyPressEventHandler(this.validaDatoNumerico);
            this.txtTarjeta.KeyPress += new KeyPressEventHandler(this.validaDatoNumerico);
        }

        #region Eventos 
        /// <summary>
        /// Valida que el dato ingresado sea un número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validaDatoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Al cambiar el valor del textbox, realiza calculos de vuelto y pendiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
            double tarjetaIngresado = !string.IsNullOrEmpty(txtTarjeta.Text) ? Convert.ToDouble(txtTarjeta.Text) : 0;
            double totalMontos = tarjetaIngresado + efectivoIngresado;

            lblPendiente.Text = operations.TotalPendiente(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
            lblVuelto.Text = operations.TotalVuelto(totalMontos).ToString("C2", new System.Globalization.CultureInfo("es-cr"));
        }

        /// <summary>
        /// Al cambiar el valor del textbox, realiza calculos de vuelto y pendiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

        #region Métodos privados
        private void bGeneraSaldoAleatorio()
        {
            Random rnd = new Random();
            double saldoAleatorio = rnd.Next(0, 1000); // Asigna un número en el rango asignado
            saldoTarjeta = saldoAleatorio;
            label6.Text = saldoAleatorio.ToString();
        }

        private bool bVerificarSaldo(double tarjetaIngresado)
        {
            if (tarjetaIngresado > saldoTarjeta)
                return false;
            return true;
        }
        #endregion

        #region Botones

        private void bPay_Click(object sender, EventArgs e)
        {
            double totalCompra = operations.TotalCompras();
            double efectivoIngresado = !string.IsNullOrEmpty(txtEfectivo.Text) ? Convert.ToDouble(txtEfectivo.Text) : 0;
            double tarjetaIngresado = !string.IsNullOrEmpty(txtTarjeta.Text) ? Convert.ToDouble(txtTarjeta.Text) : 0;

            double totalPagado = efectivoIngresado + tarjetaIngresado;
            double diferencia = totalPagado - totalCompra;

            if (diferencia < 0)
            {
                MessageBox.Show("El monto ingresado es insuficiente para completar la compra.", "Pago Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productos = operations.IndexCompras();

            // Registrar venta realizada en la pila
            GlobalOperations.RegistrarOrden(totalCompra, efectivoIngresado, tarjetaIngresado, productos);

            operations.ClearCompras(); //Limpia la lista de comprar, lo prepara para la próxima

            MessageBox.Show("Pago realizado con éxito. ¡Gracias por su compra!", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Form1 vendingMachine = new Form1();
            vendingMachine.Show();
            this.Hide();
        }
        #endregion

    }
}
