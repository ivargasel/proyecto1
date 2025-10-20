using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_expendedora
{
    public partial class Form1 : Form
    {
        const int FILAS = 5;
        const int COLUMNAS = 3;

        private class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

            public Producto(string nombre, decimal precio)
            {
                Nombre = nombre;
                Precio = precio;
            }
        }

        private Queue<Producto>[,] inventario = new Queue<Producto>[FILAS, COLUMNAS];

        public Form1()
        {
            InitializeComponent();
            InicializarColas();
            PintarRejilla();
            btnComprar.Click += BtnComprar_Click;
        }

        
        private void InicializarColas()
        {
            for (int f = 0; f < FILAS; f++)
                for (int c = 0; c < COLUMNAS; c++)
                    inventario[f, c] = new Queue<Producto>();

            
            string[,] nombres = {
                { "Coca-Cola", "Papas Pringles", "Snickers" },
                { "Pepsi", "Doritos", "Hershey's" },
                { "7Up", "Ranchitas", "Oreo" },
                { "Fanta", "Picaritas", "Trident" },
                { "Agua", "Club Social", "Ferrero" }
            };

            decimal[,] precios = {
                { 950, 700, 800 },
                { 900, 650, 850 },
                { 850, 600, 750 },
                { 880, 650, 700 },
                { 500, 600, 1200 }
            };

            int[,] cantidades = {
                { 3, 2, 4 },
                { 3, 3, 2 },
                { 4, 2, 5 },
                { 3, 2, 5 },
                { 5, 4, 3 }
            };

            for (int f = 0; f < FILAS; f++)
            {
                for (int c = 0; c < COLUMNAS; c++)
                {
                    for (int k = 0; k < cantidades[f, c]; k++)
                    {
                        inventario[f, c].Enqueue(new Producto(nombres[f, c], precios[f, c]));
                    }
                }
            }
        }

    
        private void PintarRejilla()
        {
            tblMatriz.Controls.Clear();
            tblMatriz.ColumnStyles.Clear();
            tblMatriz.RowStyles.Clear();
            tblMatriz.ColumnCount = COLUMNAS;
            tblMatriz.RowCount = FILAS;

            for (int c = 0; c < COLUMNAS; c++)
                tblMatriz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / COLUMNAS));

            for (int f = 0; f < FILAS; f++)
                tblMatriz.RowStyles.Add(new RowStyle(SizeType.Absolute, 80f));

            
            for (int f = 1; f <= FILAS; f++)
            {
                for (int c = 1; c <= COLUMNAS; c++)
                {
                    var btn = new Button
                    {
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.LightGray,
                        Tag = (f, c),
                        Text = TextoDeCasilla(f, c)
                    };
                    btn.Click += BotonCasilla_Click;
                    tblMatriz.Controls.Add(btn, c - 1, f - 1);
                }
            }

            MostrarOk("✅ Lista. Selecciona casilla, pon Cant y Depósito, luego Comprar.");
        }

        string TextoDeCasilla(int fila1, int col1)
        {
            int f = fila1 - 1, c = col1 - 1;
            var cola = inventario[f, c];

            if (cola.Count == 0)
                return "Vacío\r\nCant: 0\r\n₡0.00";

            var p = cola.Peek();
            return $"{p.Nombre}\r\nCant: {cola.Count}\r\n₡{p.Precio:0.00}";
        }

        
        private void BotonCasilla_Click(object sender, EventArgs e)
        {
            if (sender is Button b && b.Tag is ValueTuple<int, int> pos)
            {
                txtFila.Text = pos.Item1.ToString();
                txtCol.Text = pos.Item2.ToString();
                MostrarOk($"Casilla F{pos.Item1} C{pos.Item2} seleccionada.");
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFila.Text, out int fila1) ||
                !int.TryParse(txtCol.Text, out int col1))
            {
                MostrarError("Fila/Col inválidas.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MostrarError("Cantidad inválida.");
                return;
            }

            if (!decimal.TryParse(txtDeposito.Text, out decimal deposito))
            {
                MostrarError("Depósito inválido.");
                return;
            }

            if (!(fila1 >= 1 && fila1 <= FILAS && col1 >= 1 && col1 <= COLUMNAS))
            {
                MostrarError("Código inválido. Fila 1-5 / Col 1-3.");
                return;
            }

            int f = fila1 - 1;
            int c = col1 - 1;
            var cola = inventario[f, c];

            if (cola.Count == 0)
            {
                MostrarError("Producto no disponible.");
                return;
            }

            var producto = cola.Peek();
            decimal total = producto.Precio * cantidad;

            if (deposito < total)
            {
                MostrarError($"Fondos insuficientes. Total: ₡{total:0.00}");
                return;
            }

            int vendidos = 0;
            while (vendidos < cantidad && cola.Count > 0)
            {
                cola.Dequeue();
                vendidos++;
            }

            decimal vuelto = deposito - total;
            MostrarOk($"¡Gracias! Llévate {vendidos} × {producto.Nombre}. Vuelto: ₡{vuelto:0.00}");
            RefrescarBoton(fila1, col1);
        }

        private void RefrescarBoton(int fila1, int col1)
        {
            foreach (Control ctl in tblMatriz.Controls)
            {
                if (ctl is Button b && b.Tag is ValueTuple<int, int> pos &&
                    pos.Item1 == fila1 && pos.Item2 == col1)
                {
                    b.Text = TextoDeCasilla(fila1, col1);
                    break;
                }
            }
        }

        private void MostrarOk(string t)
        {
            lblMensaje.ForeColor = Color.DarkBlue;
            lblMensaje.Text = "ℹ️ " + t;
        }

        private void MostrarError(string t)
        {
            lblMensaje.ForeColor = Color.DarkRed;
            lblMensaje.Text = "⚠️ " + t;
        }
    }
}