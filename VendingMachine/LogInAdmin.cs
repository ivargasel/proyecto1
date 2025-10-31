using System;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class LogInAdmin : Form
    {
        public LogInAdmin()
        {
            InitializeComponent();
        }

        private void bLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserAdmin.Text.Trim();
            string password = txtPassAdmin.Text.Trim();

            if (username == "admin" && password == "admin123")
            {
                Admin adminPanel = new Admin();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña Inválida. Por favor intente de nuevo.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Form1 vendingMachine = new Form1();
            vendingMachine.Show();
            this.Hide();
        }
    }
}
