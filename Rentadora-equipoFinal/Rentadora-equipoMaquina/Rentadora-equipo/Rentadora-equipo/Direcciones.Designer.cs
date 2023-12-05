
namespace Rentadora_equipo
{
    partial class frmDirecciones
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
            this.LblInicioSesion = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.nmDep = new System.Windows.Forms.NumericUpDown();
            this.nmMuni = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMuni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // LblInicioSesion
            // 
            this.LblInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInicioSesion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioSesion.Location = new System.Drawing.Point(106, -1);
            this.LblInicioSesion.Name = "LblInicioSesion";
            this.LblInicioSesion.Size = new System.Drawing.Size(460, 58);
            this.LblInicioSesion.TabIndex = 2;
            this.LblInicioSesion.Text = "Agregar Direcciones del cliente";
            this.LblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblInicioSesion.Click += new System.EventHandler(this.LblInicioSesion_Click);
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(469, 214);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(98, 20);
            this.txtNumeroCasa.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(466, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 21);
            this.label15.TabIndex = 55;
            this.label15.Text = "Numero Casa";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(319, 214);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 20);
            this.txtCalle.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(316, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 53;
            this.label14.Text = "Calle";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(66, 207);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(234, 20);
            this.txtColonia.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 21);
            this.label13.TabIndex = 51;
            this.label13.Text = "Colonia";
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(319, 112);
            this.cboMunicipio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(120, 21);
            this.cboMunicipio.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 47;
            this.label11.Text = "Municipio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "Departamento";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(66, 112);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(134, 21);
            this.cboDepartamento.TabIndex = 45;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(286, 304);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(163, 41);
            this.btnSiguiente.TabIndex = 57;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatos.Location = new System.Drawing.Point(66, 304);
            this.btnAgregarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(163, 41);
            this.btnAgregarDatos.TabIndex = 58;
            this.btnAgregarDatos.Text = "Agregar Datos";
            this.btnAgregarDatos.UseVisualStyleBackColor = true;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // nmDep
            // 
            this.nmDep.Location = new System.Drawing.Point(66, 136);
            this.nmDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmDep.Name = "nmDep";
            this.nmDep.Size = new System.Drawing.Size(90, 20);
            this.nmDep.TabIndex = 59;
            // 
            // nmMuni
            // 
            this.nmMuni.Location = new System.Drawing.Point(319, 137);
            this.nmMuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmMuni.Name = "nmMuni";
            this.nmMuni.Size = new System.Drawing.Size(90, 20);
            this.nmMuni.TabIndex = 60;
            // 
            // frmDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 406);
            this.Controls.Add(this.nmMuni);
            this.Controls.Add(this.nmDep);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.LblInicioSesion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDirecciones";
            this.Text = "Direcciones";
            this.Load += new System.EventHandler(this.frmDirecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblInicioSesion;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.NumericUpDown nmDep;
        private System.Windows.Forms.NumericUpDown nmMuni;
    }
}