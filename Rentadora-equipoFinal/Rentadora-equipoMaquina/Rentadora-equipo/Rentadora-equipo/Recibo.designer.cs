namespace Rentadora_equipo
{
    partial class Recibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtFechaAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCrearRecibo = new System.Windows.Forms.Button();
            this.txtNumRecibo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstadoRecibo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.14545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIBO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Concepto de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Alquiler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Devolucion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número Recibo:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(171, 317);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(840, 30);
            this.textBox2.TabIndex = 8;
            // 
            // dtFechaAlquiler
            // 
            this.dtFechaAlquiler.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaAlquiler.Location = new System.Drawing.Point(214, 371);
            this.dtFechaAlquiler.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaAlquiler.Name = "dtFechaAlquiler";
            this.dtFechaAlquiler.Size = new System.Drawing.Size(409, 30);
            this.dtFechaAlquiler.TabIndex = 9;
            // 
            // dtFechaDevolucion
            // 
            this.dtFechaDevolucion.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDevolucion.Location = new System.Drawing.Point(214, 457);
            this.dtFechaDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaDevolucion.Name = "dtFechaDevolucion";
            this.dtFechaDevolucion.Size = new System.Drawing.Size(412, 30);
            this.dtFechaDevolucion.TabIndex = 10;
            // 
            // btnCrearRecibo
            // 
            this.btnCrearRecibo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRecibo.Location = new System.Drawing.Point(825, 374);
            this.btnCrearRecibo.Name = "btnCrearRecibo";
            this.btnCrearRecibo.Size = new System.Drawing.Size(145, 49);
            this.btnCrearRecibo.TabIndex = 11;
            this.btnCrearRecibo.Text = "Crear Recibo";
            this.btnCrearRecibo.UseVisualStyleBackColor = true;
            this.btnCrearRecibo.Click += new System.EventHandler(this.btnCrearRecibo_Click);
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.Location = new System.Drawing.Point(184, 525);
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(100, 22);
            this.txtNumRecibo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado Recibo:";
            // 
            // txtEstadoRecibo
            // 
            this.txtEstadoRecibo.Location = new System.Drawing.Point(476, 524);
            this.txtEstadoRecibo.Name = "txtEstadoRecibo";
            this.txtEstadoRecibo.Size = new System.Drawing.Size(136, 22);
            this.txtEstadoRecibo.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(588, 152);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(409, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 573);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEstadoRecibo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumRecibo);
            this.Controls.Add(this.btnCrearRecibo);
            this.Controls.Add(this.dtFechaDevolucion);
            this.Controls.Add(this.dtFechaAlquiler);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.Recibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtFechaAlquiler;
        private System.Windows.Forms.DateTimePicker dtFechaDevolucion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCrearRecibo;
        private System.Windows.Forms.TextBox txtNumRecibo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstadoRecibo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}