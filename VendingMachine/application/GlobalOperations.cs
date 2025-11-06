using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VendingMachine.models;
using VendingMachine.Models;

namespace Vending_Machine.Application
{
    public class GlobalOperations
    {
        const int rows = 5;
        const int cols = 3;

        //Arreglo de productos que se van a utilizar para la máquina
        public string[,] NombresProductos { get; set; } = new string[rows, cols]
        {
            { "CHEETOS", "CHIPS AHOY", "COCA COLA" },
            { "DORITOS", "GATORADE", "KITKAT" },
            { "MONSTER", "OREO", "PEPSI" },
            { "REDBULL", "SKITTLES", "SNICKERS" },
            { "SPRITE", "DR.PEPPER", "FANTA" }
        };
        
        //Matriz bidimencional de pilas, cada celda hace referencia a una cola de producto.
        public static Queue<Producto>[,] Inventario { get; set; } = new Queue<Producto>[rows, cols];
        
        //Pila que almacenará todas las compras que se realicen en la máquina
        public static Stack<VentasRealizadas> HistorialVentas { get; set; } = new Stack<VentasRealizadas>();

        public static List<string> Compras { get; set; } = new List<string>();

        //Inicialización de cada pila dentro de la matriz, con los productos ya establecidos.
        public void InicializarInventario()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Inventario[i, j] = new Queue<Producto>(); // Cola vacía pero inicializada
                }
            }
        }

        //Busca la coordenada en la matriz por el nombre del ítem
        public (int fila, int columna)? BuscarCoordenadasPorNombre(string nombreProducto)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string nombreActual = NombresProductos[i, j];
                    if (nombreActual.Equals(nombreProducto))
                    {
                        return (i, j); 
                    }
                }
            }

            return null; 
        }

        public string CreateInventario(string nombreProducto, decimal precio, int cantidad)
        {
            // Valida que las entradas sean correctas
            if (string.IsNullOrWhiteSpace(nombreProducto) || cantidad <= 0 || precio <= 0)
                return "Por favor, ingrese un nombre de producto válido, una cantidad y un precio mayor a cero.";

            var coordenadas = BuscarCoordenadasPorNombre(nombreProducto);
            int fila = 0, columna = 0;

            if (coordenadas != null)
            {
                fila = coordenadas.Value.fila;
                columna = coordenadas.Value.columna;
            }
            else
                return "Producto no encontrado en el inventario.";

            // Crea la cola si esta no existe
            if (Inventario[fila, columna] == null)
                Inventario[fila, columna] = new Queue<Producto>();

            // Agregar productos a la posición en la que se encuentra el producto
            for (int i = 0; i < cantidad; i++)
            {
                Inventario[fila, columna].Enqueue(new Producto(nombreProducto, 1, precio));
            }

            return $"Se agregaron {cantidad} unidades del ítem '{nombreProducto}'.";
        }

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
                    var cola = Inventario[i, j];
                    int cantidad = cola?.Count ?? 0;

                    if (cantidad > 0)
                    {
                        var producto = cola.Peek();
                        value += $"Producto: {producto.Nombre} | Cantidad: {cantidad} | Precio: {producto.Precio:C} \n";
                    }
                }
            }
            return value;
        }

        /// <summary>
        /// Esta función maneja la compra de un producto seleccionado por el usuario.
        /// </summary>
        /// <param name="productoSeleccionado"></param>
        public void Comprar(int row, int col)
        {
            // Validar que la cola exista y tenga productos
            var cola = Inventario[row, col];

            if (cola == null || cola.Count <= 0)
            {
                MessageBox.Show("No hay existencias del producto seleccionado.", "Producto no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // quita el producto de la cola (cuando el usuario compra)
            var productoComprado = Inventario[row, col].Dequeue();

            // Guardar una representación serializada del producto
            string compraSerializada = $"{productoComprado.Nombre}|{productoComprado.Precio}";
            Compras.Add(compraSerializada);


            MessageBox.Show($"Producto '{productoComprado.Nombre}' agregado al carrito.", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Carga una lista con los productos que se van comprando.
        /// </summary>
        /// <returns></returns>
        public List<Producto> IndexCompras()
        {
            List<Producto> data = new List<Producto>();

            foreach (var item in Compras)
            {
                string[] partes = item.Split('|'); //La lista compras almacena el nombre del producto|precio

                if (partes.Length == 2)
                {
                    string nombre = partes[0].Trim();
                    decimal precio = decimal.Parse(partes[1].Trim());

                    data.Add(new Producto(nombre, 1, precio));
                }
            }
            return data;
        }

        /// <summary>
        /// Almacena registro de venta en pila
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="efectivo"></param>
        /// <param name="tarjeta"></param>
        /// <param name="productos"></param>
        public static void RegistrarOrden(double totalCompra, double efectivo, double tarjeta, List<Producto> productos)
        {
            var orden = new VentasRealizadas
            {
                TotalCompra = totalCompra,
                Efectivo = efectivo,
                Tarjeta = tarjeta,
                Vuelto = (efectivo + tarjeta) - totalCompra,
                Productos = productos,
                FechaHora = DateTime.Now
            };

            HistorialVentas.Push(orden);
        }
        
        /// <summary>
        /// Limpia la lista que registra las compras realizadas.
        /// </summary>
        public void ClearCompras()
        {
            Compras.Clear();
        }

        #region Calculo de totales y vueltos
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
                    string[] partes = item.Split('|'); //La lista compras almacena el nombre del producto|precio

                    if (partes.Length == 2)
                    {
                        double precio = double.Parse(partes[1].Trim());
                        value += precio;
                    }
                }
            }
            return value;
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
            if (pago < total)
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
        #endregion

        /// <summary>
        /// Método que carga la matriz con datos aleatorios, para pruebas
        /// </summary>
        public void CargarInventarioAleatorio()
        {
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Asegurar que la cola está inicializada
                    if (Inventario[i, j] == null)
                        Inventario[i, j] = new Queue<Producto>();

                    // Limpiar por si ya tenía productos
                    Inventario[i, j].Clear();

                    // Obtener nombre del producto desde la matriz base
                    string nombre = NombresProductos[i, j];

                    // Generar cantidad aleatoria (entre 1 y 10)
                    int cantidad = random.Next(1, 11);

                    // Generar precio aleatorio entre ₡500 y ₡2000
                    decimal precio = random.Next(500, 2001); // en colones

                    // Convertir a decimal con 2 decimales si se desea (opcional)
                    precio = Math.Round(precio / 100m, 2); // Ej: ₡5.00 a ₡20.00

                    // Agregar los productos a la cola
                    for (int k = 0; k < cantidad; k++)
                    {
                        Inventario[i, j].Enqueue(new Producto(nombre, 1, precio));
                    }
                }
            }
        }

    }
}