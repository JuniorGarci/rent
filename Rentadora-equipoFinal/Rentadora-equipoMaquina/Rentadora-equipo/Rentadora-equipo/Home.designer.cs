namespace Rentadora_equipo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarMaquina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.14545F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(16, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Chartreuse;
            this.btnFactura.Location = new System.Drawing.Point(144, 10);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(100, 28);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maquinaria,
            this.Descripcion});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(33, 205);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 548);
            this.dataGridView1.TabIndex = 4;
            // 
            // Maquinaria
            // 
            this.Maquinaria.HeaderText = "Maquinaria";
            this.Maquinaria.MinimumWidth = 6;
            this.Maquinaria.Name = "Maquinaria";
            this.Maquinaria.Width = 400;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAgregarMaquina.Location = new System.Drawing.Point(16, 79);
            this.btnAgregarMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.Size = new System.Drawing.Size(151, 29);
            this.btnAgregarMaquina.TabIndex = 5;
            this.btnAgregarMaquina.Text = "Agregar Maquina";
            this.btnAgregarMaquina.UseVisualStyleBackColor = false;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGuardarOrden.Location = new System.Drawing.Point(186, 79);
            this.btnGuardarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(151, 29);
            this.btnGuardarOrden.TabIndex = 7;
            this.btnGuardarOrden.Text = "Crear Orden";
            this.btnGuardarOrden.UseVisualStyleBackColor = false;
            this.btnGuardarOrden.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 751);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnAgregarMaquina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardarOrden;
    }
}