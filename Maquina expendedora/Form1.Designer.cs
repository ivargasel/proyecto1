namespace Maquina_expendedora
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario (deben coincidir con Form1.cs)
        private System.Windows.Forms.TableLayoutPanel tblMatriz;
        private System.Windows.Forms.FlowLayoutPanel flwBarra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Button btnComprar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tblMatriz = new System.Windows.Forms.TableLayoutPanel();
            this.flwBarra = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.flwBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMatriz
            // 
            this.tblMatriz.BackColor = System.Drawing.Color.Silver;
            this.tblMatriz.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMatriz.ColumnCount = 3;
            this.tblMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblMatriz.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblMatriz.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMatriz.Location = new System.Drawing.Point(0, 0);
            this.tblMatriz.Name = "tblMatriz";
            this.tblMatriz.RowCount = 5;
            this.tblMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMatriz.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMatriz.Size = new System.Drawing.Size(800, 380);
            this.tblMatriz.TabIndex = 0;
            // 
            // flwBarra
            // 
            this.flwBarra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flwBarra.Controls.Add(this.txtFila);
            this.flwBarra.Controls.Add(this.txtCol);
            this.flwBarra.Controls.Add(this.txtCantidad);
            this.flwBarra.Controls.Add(this.txtDeposito);
            this.flwBarra.Controls.Add(this.btnComprar);
            this.flwBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.flwBarra.Location = new System.Drawing.Point(0, 380);
            this.flwBarra.Name = "flwBarra";
            this.flwBarra.Padding = new System.Windows.Forms.Padding(10);
            this.flwBarra.Size = new System.Drawing.Size(800, 70);
            this.flwBarra.TabIndex = 1;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(13, 13);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(40, 22);
            this.txtFila.TabIndex = 1;
            this.txtFila.Text = "1";
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(59, 13);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(40, 22);
            this.txtCol.TabIndex = 2;
            this.txtCol.Text = "1";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(105, 13);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "1";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(161, 13);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(80, 22);
            this.txtDeposito.TabIndex = 4;
            // 
            // btnComprar
            // 
            this.btnComprar.AutoSize = true;
            this.btnComprar.Location = new System.Drawing.Point(247, 13);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 26);
            this.btnComprar.TabIndex = 5;
            this.btnComprar.Text = "Comprar";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(0, 450);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(10);
            this.lblMensaje.Size = new System.Drawing.Size(800, 100);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Máquina lista para usar.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.flwBarra);
            this.Controls.Add(this.tblMatriz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina Expendedora (Forms listo)";
            this.flwBarra.ResumeLayout(false);
            this.flwBarra.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}