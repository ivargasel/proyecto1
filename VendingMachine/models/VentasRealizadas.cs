using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.models
{
    public class VentasRealizadas
    {
        public double TotalCompra { get; set; }
        public double Efectivo { get; set; }
        public double Tarjeta { get; set; }
        public double Vuelto { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public DateTime FechaHora { get; set; }

        /// <summary>
        /// Crea un resumen de productos
        /// </summary>
        public string ResumenProductos => string.Join(", ", Productos.Select(p => $"{p.Nombre}"));

    }
}
