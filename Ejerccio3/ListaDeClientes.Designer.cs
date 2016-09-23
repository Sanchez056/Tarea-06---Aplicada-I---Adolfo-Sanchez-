namespace Ejerccio3
{
    partial class ListasClientes
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
            this.LlamarClienteBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteslistBox1 = new System.Windows.Forms.ListBox();
            this.ListaClienteLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LlamarClienteBotton
            // 
            this.LlamarClienteBotton.Location = new System.Drawing.Point(12, 61);
            this.LlamarClienteBotton.Name = "LlamarClienteBotton";
            this.LlamarClienteBotton.Size = new System.Drawing.Size(107, 23);
            this.LlamarClienteBotton.TabIndex = 0;
            this.LlamarClienteBotton.Text = "LLamar Clientes";
            this.LlamarClienteBotton.UseVisualStyleBackColor = true;
            this.LlamarClienteBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "El Primero el Llegar Primero en Salir";
            // 
            // ClienteslistBox1
            // 
            this.ClienteslistBox1.FormattingEnabled = true;
            this.ClienteslistBox1.Location = new System.Drawing.Point(12, 128);
            this.ClienteslistBox1.Name = "ClienteslistBox1";
            this.ClienteslistBox1.Size = new System.Drawing.Size(120, 95);
            this.ClienteslistBox1.TabIndex = 3;
            // 
            // ListaClienteLabel2
            // 
            this.ListaClienteLabel2.AutoSize = true;
            this.ListaClienteLabel2.Location = new System.Drawing.Point(12, 109);
            this.ListaClienteLabel2.Name = "ListaClienteLabel2";
            this.ListaClienteLabel2.Size = new System.Drawing.Size(82, 13);
            this.ListaClienteLabel2.TabIndex = 4;
            this.ListaClienteLabel2.Text = "Lista de Cliente ";
            // 
            // ListasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.ListaClienteLabel2);
            this.Controls.Add(this.ClienteslistBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LlamarClienteBotton);
            this.Name = "ListasClientes";
            this.Text = "Lista de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LlamarClienteBotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ClienteslistBox1;
        private System.Windows.Forms.Label ListaClienteLabel2;
    }
}

