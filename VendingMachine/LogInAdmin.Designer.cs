namespace VendingMachine
{
    partial class LogInAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserAdmin = new System.Windows.Forms.TextBox();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bLogIn = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Administrativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el usuario y contraseña para ingresar al panel de administración de la má" +
    "quina.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.Location = new System.Drawing.Point(105, 129);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.Size = new System.Drawing.Size(206, 20);
            this.txtUserAdmin.TabIndex = 3;
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(105, 155);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '*';
            this.txtPassAdmin.Size = new System.Drawing.Size(206, 20);
            this.txtPassAdmin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña";
            // 
            // bLogIn
            // 
            this.bLogIn.Location = new System.Drawing.Point(128, 183);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(75, 23);
            this.bLogIn.TabIndex = 7;
            this.bLogIn.Text = "Ingresar";
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(209, 183);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // LogInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 218);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserAdmin;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Button bCancel;
    }
}