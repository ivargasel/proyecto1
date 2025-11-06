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
        GlobalOperations operations = new GlobalOperations();

        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            // Convertir la pila a lista para visualizarla (opcional: invertir para mostrar la más reciente arriba)
            var historial = GlobalOperations.HistorialVentas.ToList();

            // Si quieres ver lo más reciente primero
            historial.Reverse();

            // Bind al DataGridView
            dgVentas.DataSource = historial;
        }
    }
}
