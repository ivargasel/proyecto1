using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vending_Machine.Application;

namespace VendingMachine
{
    public partial class ReporteVentas : Form
    {
        GlobalOperations operations = new GlobalOperations();
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            var ordenes = operations.IndexOrdenes();
            if (ordenes.Count > 0)
            {
                for (int i = 0; i < ordenes.Count; i++)
                {
                    //string[] value = new string[6];
                    //value = ordenes[i].Peek();

                    string[] array = ordenes.ToArray();
                    string valor = array[i];

                    lblReporte.Text += $" {valor} \n";

                }
            }
            else
            {
                lblReporte.Text = "No hay ventas registradas.";
            }
        }
    }
}
