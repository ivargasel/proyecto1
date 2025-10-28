namespace VendingMachine
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel17 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.txtProductoAdmin = new System.Windows.Forms.ListBox();
            this.txtPrecioAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.txtCantidadAdmin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label6);
            this.panel17.Controls.Add(this.lblInventario);
            this.panel17.Location = new System.Drawing.Point(19, 311);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(529, 261);
            this.panel17.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inventario";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(10, 54);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(35, 13);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "label6";
            // 
            // txtProductoAdmin
            // 
            this.txtProductoAdmin.FormattingEnabled = true;
            this.txtProductoAdmin.Location = new System.Drawing.Point(72, 92);
            this.txtProductoAdmin.Name = "txtProductoAdmin";
            this.txtProductoAdmin.Size = new System.Drawing.Size(229, 160);
            this.txtProductoAdmin.TabIndex = 39;
            // 
            // txtPrecioAdmin
            // 
            this.txtPrecioAdmin.Location = new System.Drawing.Point(72, 284);
            this.txtPrecioAdmin.Name = "txtPrecioAdmin";
            this.txtPrecioAdmin.Size = new System.Drawing.Size(148, 20);
            this.txtPrecioAdmin.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Precio";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(226, 282);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 36;
            this.button16.Text = "Agregar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // txtCantidadAdmin
            // 
            this.txtCantidadAdmin.Location = new System.Drawing.Point(72, 258);
            this.txtCantidadAdmin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadAdmin.Name = "txtCantidadAdmin";
            this.txtCantidadAdmin.Size = new System.Drawing.Size(148, 20);
            this.txtCantidadAdmin.TabIndex = 35;
            this.txtCantidadAdmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Panel Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Producto";
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Location = new System.Drawing.Point(307, 282);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 41;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seleccione el producto que desea agregar, luego ingrese la cantidad y el precio.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(451, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Finalmente le da click en \'Agregar\'. Al finalizar seleccione \'Cerrar\' para volver" +
    " al menú principal.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Reporte Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(563, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.txtProductoAdmin);
            this.Controls.Add(this.txtPrecioAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.txtCantidadAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.ListBox txtProductoAdmin;
        private System.Windows.Forms.TextBox txtPrecioAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.NumericUpDown txtCantidadAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}