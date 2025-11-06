using System;
using System.Windows.Forms;
using Vending_Machine.Application;

namespace VendingMachine
{
    public partial class Admin : Form
    {
        GlobalOperations operations = new GlobalOperations();

        public Admin()
        {
            InitializeComponent();
            MostrarInventario();
            pvCargarListadoItems();

            //Asigna al control el evento
            this.txtPrecio.KeyPress += new KeyPressEventHandler(this.validaDatoNumerico);
        }

        #region Métodos privados
        //Carga el list box con la lista de productos definidos en el array
        private void pvCargarListadoItems()
        {
            lboxProductos.Items.Clear();
            lboxProductos.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string nombre = operations.NombresProductos[i, j];
                    lboxProductos.Items.Add(nombre);
                }
            }
        }

        /// <summary>
        /// Esta función muestra el inventario actual en la etiqueta correspondiente.
        /// </summary>
        private void MostrarInventario()
        {
            lblInventario.Text = operations.IndexInventario();
        }

        /// <summary>
        /// Verifica que el dato que se está ingresando es un número
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

        #endregion

        #region Opciones del menú
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReporteVentas reporte = new ReporteVentas();
            reporte.Show();
        }

        #endregion

        #region Botones
        /// <summary>
        /// Botón que registra inventario en la cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregaInventario_Click(object sender, EventArgs e)
        {
            string producto = lboxProductos.Text.Trim();
            int cantidad = (int)txtCantidadAdmin.Value;
            decimal precio = !string.IsNullOrEmpty(txtPrecio.Text.Trim()) ? Convert.ToDecimal(txtPrecio.Text.Trim()) : 0;

            var response = operations.CreateInventario(producto, precio, cantidad);

            MostrarInventario();
        }

        /// <summary>
        /// Crea inventario aleatorio para pruebas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMercanciaDefault_Click(object sender, EventArgs e)
        {
            operations.CargarInventarioAleatorio();
        }
        #endregion
    }
}