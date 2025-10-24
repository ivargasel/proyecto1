namespace VendingMachine
{
    partial class Payment
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bPay = new System.Windows.Forms.Button();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(156, 251);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bPay
            // 
            this.bPay.Location = new System.Drawing.Point(75, 251);
            this.bPay.Name = "bPay";
            this.bPay.Size = new System.Drawing.Size(75, 23);
            this.bPay.TabIndex = 15;
            this.bPay.Text = "Pagar";
            this.bPay.UseVisualStyleBackColor = true;
            this.bPay.Click += new System.EventHandler(this.bPay_Click);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(87, 162);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(206, 20);
            this.txtTarjeta.TabIndex = 14;
            this.txtTarjeta.TextChanged += new System.EventHandler(this.txtTarjeta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tarjeta";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(87, 136);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(206, 20);
            this.txtEfectivo.TabIndex = 12;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Efectivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese el monto con el que va a pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Método de Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(167, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 24);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total a Pagar";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(169, 206);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(68, 24);
            this.lblVuelto.TabIndex = 20;
            this.lblVuelto.Text = "monto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Vuelto";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 301);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bPay);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bPay;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label label7;
    }
}