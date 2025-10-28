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
        }

        /// <summary>
        /// Esta función muestra el inventario actual en la etiqueta correspondiente.
        /// </summary>
        private void MostrarInventario()
        {
            lblInventario.Text = operations.IndexInventario();
        }

        /// <summary>
        /// Esta función maneja el evento de clic del botón "Cerrar" para volver al formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCerrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        /// <summary>
        /// Esta función maneja el evento de clic del botón para agregar stock al inventario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            string producto = txtProductoAdmin.Text.Trim();
            int cantidad = (int)txtCantidadAdmin.Value;
            decimal precio = !string.IsNullOrEmpty(txtPrecioAdmin.Text.Trim()) ? Convert.ToDecimal(txtPrecioAdmin.Text.Trim()) : 0;

            var response = operations.CreateInventario(producto, cantidad, precio);
            MessageBox.Show(response, "Stock Agregado");
            MostrarInventario();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    txtProductoAdmin.Items.Add(operations.Inventario[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteVentas reporte = new ReporteVentas();
            reporte.Show();
        }
    }
}
