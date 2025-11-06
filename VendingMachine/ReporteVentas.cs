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
using VendingMachine.models;

namespace VendingMachine
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // Convertir la pila de ventas a lista para asignarla al grid
            var historial = GlobalOperations.HistorialVentas.ToList();
            
            // Bind al grid con la lista de ventas
            dgVentas.DataSource = historial;
        }
    }
}
