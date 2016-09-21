namespace Ejercccio_1
{
    partial class CalificacionesSalonClases
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.InsertCalificacionLabel = new System.Windows.Forms.Label();
            this.InserteCalificacionTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(146, 27);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // InsertCalificacionLabel
            // 
            this.InsertCalificacionLabel.AutoSize = true;
            this.InsertCalificacionLabel.Location = new System.Drawing.Point(13, 13);
            this.InsertCalificacionLabel.Name = "InsertCalificacionLabel";
            this.InsertCalificacionLabel.Size = new System.Drawing.Size(101, 13);
            this.InsertCalificacionLabel.TabIndex = 1;
            this.InsertCalificacionLabel.Text = "Insert Calificaciones";
            // 
            // InserteCalificacionTextBox
            // 
            this.InserteCalificacionTextBox.Location = new System.Drawing.Point(16, 30);
            this.InserteCalificacionTextBox.Name = "InserteCalificacionTextBox";
            this.InserteCalificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.InserteCalificacionTextBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // CalificacionesSalonClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.InserteCalificacionTextBox);
            this.Controls.Add(this.InsertCalificacionLabel);
            this.Controls.Add(this.CalcularButton);
            this.Name = "CalificacionesSalonClases";
            this.Text = "Calificaciones de Un Salon de Clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label InsertCalificacionLabel;
        private System.Windows.Forms.TextBox InserteCalificacionTextBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

