using VendingMachine.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vending_Machine.Application
{
    public class GlobalOperations
    {
        const int rows = 5;
        const int cols = 3;
        /// <summary>
        /// Cola utilizada para almacenar pilas de productos en el inventario.
        /// </summary>
        /// 
        public static string[,] Productos { get; set; } = new string[rows, cols]
        {
            { "CHEETOS", "CHIPS AHOY", "COCA COLA" },
            { "DORITOS", "GATORADE", "KITKAT" },
            { "MONSTER", "OREO", "PEPSI" },
            { "REDBULL", "SKITTLES", "SNICKERS" },
            { "SPRITE", "DR.PEPPER", "FANTA" }
        };

        public string[,] Inventario { get; set; } = Productos;
        public static int[,] Cantidad { get; set; } = new int[rows, cols];
        public static double[,] Precios { get; set; } = new double[rows, cols];
        public static List<string> Compras { get; set; } = new List<string>();
        public static Queue<string> Ordenes { get; set; } = new Queue<string>();

        /// <summary>
        /// Esta función devuelve una representación en cadena del inventario actual.
        /// </summary>
        /// <returns></returns>
        public string IndexInventario()
        {
            string value = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Cantidad[i,j] > 0)
                    {
                        value += $"Producto: {Productos[i, j]} | Cantidad: {Cantidad[i, j]} | Precio {Precios[i, j]} \n";
                    }                        
                }
            }

            return value;
        }

        /// <summary>
        /// Esta función crea o actualiza el inventario con un nuevo producto, cantidad y precio.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        public string CreateInventario(string producto, int cantidad, decimal precio)
        {
            string response = string.Empty;
            if (string.IsNullOrEmpty(producto) || cantidad <= 0 || precio <= 0)
            {
                response = "Por favor, ingrese un nombre de producto válido, una cantidad y un precio mayor a cero.";
                return response;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Productos[i, j] == producto)
                    {
                        Cantidad[i, j] += cantidad;
                        Precios[i, j] = (double)precio;
                    }
                }
            }

            response = $"Se agregaron {cantidad} de {producto} en el inventario.";
            return response;
        }

        /// <summary>
        /// Esta función maneja la compra de un producto seleccionado por el usuario.
        /// </summary>
        /// <param name="productoSeleccionado"></param>
        public void Comprar(int row, int col)
        {
            if ((int)Cantidad[row, col] <= 0)
            {
                MessageBox.Show("Lo sentimos, el producto seleccionado no está disponible en este momento.", "Producto no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Cantidad[row, col] -= 1;

                string value = $"[{row}, {col}]";
                
                Compras.Add(value);
                MessageBox.Show("Producto agregado al carrito.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Producto> IndexCompras()
        {
            List<Producto> data = new List<Producto>();
            if (Compras.Count > 0)
            {
                foreach (var item in Compras)
                {
                    string[] row = item.Trim('[', ']').Split(',');
                    int[,] matriz = new int[1, 2];

                    matriz[0, 0] = int.Parse(row[0].Trim());
                    matriz[0, 1] = int.Parse(row[1].Trim());

                    data.Add(new Producto(Productos[matriz[0, 0], matriz[0, 1]], 1, (decimal)Precios[matriz[0, 0], matriz[0, 1]]));
                }
            }

            return data;
        }

        /// <summary>
        /// Función que calcula el total de las compras realizadas.
        /// </summary>
        /// <returns></returns>
        public double TotalCompras()
        {
            double value = 0;
            if (Compras.Count > 0)
            {
                foreach (var item in Compras)
                {
                    string[] row = item.Trim('[', ']').Split(',');
                    int[,] matriz = new int[1, 2];

                    matriz[0, 0] = int.Parse(row[0].Trim());
                    matriz[0, 1] = int.Parse(row[1].Trim());

                    value += Precios[matriz[0, 0], matriz[0, 1]];
                }
            }

            return value;
        }

        public void ClearCompras()
        {
            Compras.Clear();
        }

        /// <summary>
        /// Función que calcula el vuelto a entregar al cliente.
        /// </summary>
        /// <param name="pago"></param>
        /// <returns></returns>
        public double TotalPendiente(double pago)
        {
            double total = TotalCompras();
            double pendiente = 0;
            if (pago  < total)
                pendiente = total - pago;
            return pendiente;
        }

        /// <summary>
        /// Función que calcula el vuelto a entregar al cliente.
        /// </summary>
        /// <returns></returns>
        public double TotalVuelto()
        {
            double total = TotalCompras();
            double vuelto = total;
            return vuelto;
        }

        /// <summary>
        /// Función que calcula el vuelto a entregar al cliente.
        /// </summary>
        /// <returns></returns>
        public double TotalVuelto(double pago)
        {
           double total = TotalCompras();
            double vuelto = 0;
            if (pago > total)
            {
                vuelto = pago - total;
            }

            return vuelto;
        }

        /// <summary>
        /// Función que crea una orden y la agrega a la cola de órdenes.
        /// </summary>
        /// <param name="orden"></param>
        public void CreateOrdenes(string orden)
        {
            Ordenes.Enqueue(orden);
        }

        public Queue<string> IndexOrdenes()
        {
            return Ordenes;
        }
    }
}