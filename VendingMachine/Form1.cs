using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vending_Machine.Application;
using VendingMachine.Models;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        GlobalOperations operations = new GlobalOperations();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image cheetos = Image.FromFile(@"assets\logos\cheetos.png");
            bproducto1.Image = cheetos;
            bproducto1.BackgroundImageLayout = ImageLayout.Stretch;

            Image chipAhoy = Image.FromFile(@"assets\logos\chips ahoy.png");
            bproducto2.Image = chipAhoy;
            bproducto2.BackgroundImageLayout = ImageLayout.Stretch;

            Image cocaCola = Image.FromFile(@"assets\logos\coca cola.png");
            bproducto3.Image = cocaCola;
            bproducto3.BackgroundImageLayout = ImageLayout.Stretch;

            Image doritos = Image.FromFile(@"assets\logos\doritos.png");
            bproducto4.Image = doritos;
            bproducto4.BackgroundImageLayout = ImageLayout.Stretch;

            Image gatorade = Image.FromFile(@"assets\logos\gatorade.png");
            bproducto5.Image = gatorade;
            bproducto5.BackgroundImageLayout = ImageLayout.Stretch;

            Image kitKat = Image.FromFile(@"assets\logos\kit kat.png");
            bproducto6.Image = kitKat;
            bproducto6.BackgroundImageLayout = ImageLayout.Stretch;

            Image monster = Image.FromFile(@"assets\logos\monster.png");
            bproducto7.Image = monster;
            bproducto7.BackgroundImageLayout = ImageLayout.Stretch;

            Image oreo = Image.FromFile(@"assets\logos\oreo.png");
            bproducto8.Image = oreo;
            bproducto8.BackgroundImageLayout = ImageLayout.Stretch;

            Image pepsi = Image.FromFile(@"assets\logos\pepsi.png");
            bproducto9.Image = pepsi;
            bproducto9.BackgroundImageLayout = ImageLayout.Stretch;

            Image redBull = Image.FromFile(@"assets\logos\red bull.png");
            bproducto10.Image = redBull;
            bproducto10.BackgroundImageLayout = ImageLayout.Stretch;

            Image skittles = Image.FromFile(@"assets\logos\skittles.png");
            bproducto11.Image = skittles;
            bproducto11.BackgroundImageLayout = ImageLayout.Stretch;

            Image snickers = Image.FromFile(@"assets\logos\snickers.png");
            bproducto12.Image = snickers;
            bproducto12.BackgroundImageLayout = ImageLayout.Stretch;

            Image sprite = Image.FromFile(@"assets\logos\sprite.png");
            bproducto13.Image = sprite;
            bproducto13.BackgroundImageLayout = ImageLayout.Stretch;

            Image drPepper = Image.FromFile(@"assets\logos\dr pepper.png");
            bproducto14.Image = drPepper;
            bproducto14.BackgroundImageLayout = ImageLayout.Stretch;

            Image fanta = Image.FromFile(@"assets\logos\fanta.png");
            bproducto15.Image = fanta;
            bproducto15.BackgroundImageLayout = ImageLayout.Stretch;

            Image admin = Image.FromFile(@"assets\icons\settings.ico");
            btnAdmin.Image = admin;
            btnAdmin.BackgroundImageLayout = ImageLayout.Stretch;

            Image pagar = Image.FromFile(@"assets\icons\btnPagar.png");
            btnPagar.Image = pagar;
            btnPagar.BackgroundImageLayout = ImageLayout.Zoom;

            ActualizarMontos();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LogInAdmin logInAdmin = new LogInAdmin();
            logInAdmin.Show();
            this.Hide();
        }

        public void ActualizarMontos()
        {   
            List<Producto> data = operations.IndexCompras();
            dataTable.DataSource = data.ToArray();
            dataTable.AutoGenerateColumns = false;
            lblTotal.Text = operations.TotalCompras().ToString("C2", new System.Globalization.CultureInfo("es-cr"));
        }

        private void bproducto1_Click(object sender, EventArgs e)
        {
            operations.Comprar(0, 0);
            ActualizarMontos();
        }

        private void bproducto2_Click(object sender, EventArgs e)
        {
            operations.Comprar(0, 1);
            ActualizarMontos();
        }

        private void bproducto3_Click(object sender, EventArgs e)
        {
            operations.Comprar(0, 2);
            ActualizarMontos();
        }

        private void bproducto4_Click(object sender, EventArgs e)
        {
            operations.Comprar(1, 0);
            ActualizarMontos();
        }

        private void bproducto5_Click(object sender, EventArgs e)
        {
            operations.Comprar(1, 1);
            ActualizarMontos();
        }

        private void bproducto6_Click(object sender, EventArgs e)
        {
            operations.Comprar(1, 2);
            ActualizarMontos();
        }

        private void bproducto7_Click(object sender, EventArgs e)
        {
            operations.Comprar(2, 0);
            ActualizarMontos();
        }

        private void bproducto8_Click(object sender, EventArgs e)
        {
            operations.Comprar(2, 1);
            ActualizarMontos();
        }

        private void bproducto9_Click(object sender, EventArgs e)
        {
            operations.Comprar(2, 2);
            ActualizarMontos();
        }

        private void bproducto10_Click(object sender, EventArgs e)
        {
            operations.Comprar(3, 0);
            ActualizarMontos();
        }

        private void bproducto11_Click(object sender, EventArgs e)
        {
            operations.Comprar(3, 1);
            ActualizarMontos();
        }

        private void bproducto12_Click(object sender, EventArgs e)
        {
            operations.Comprar(3, 2);
            ActualizarMontos();
        }

        private void bproducto13_Click(object sender, EventArgs e)
        {
            operations.Comprar(4, 0);
            ActualizarMontos();
        }

        private void bproducto14_Click(object sender, EventArgs e)
        {
            operations.Comprar(4, 1);
            ActualizarMontos();
        }

        private void bproducto15_Click(object sender, EventArgs e)
        {
            operations.Comprar(4, 2);
            ActualizarMontos();
        }

        #region Botones
        private void btnPagar_Click(object sender, EventArgs e)
        {
            Payment pago = new Payment();
            pago.Show();
            this.Hide();
        }

        #endregion
    }
}
