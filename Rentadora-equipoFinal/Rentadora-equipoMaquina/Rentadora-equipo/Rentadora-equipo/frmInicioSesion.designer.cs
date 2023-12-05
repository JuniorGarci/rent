
namespace Rentadora_equipo
{
    partial class frmInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblInicioSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPasword = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblRenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInicioSesion
            // 
            this.LblInicioSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInicioSesion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicioSesion.Location = new System.Drawing.Point(434, 79);
            this.LblInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInicioSesion.Name = "LblInicioSesion";
            this.LblInicioSesion.Size = new System.Drawing.Size(223, 79);
            this.LblInicioSesion.TabIndex = 0;
            this.LblInicioSesion.Text = "Inicio Sesión";
            this.LblInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblInicioSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(468, 143);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(120, 79);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Correo";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblPasword
            // 
            this.lblPasword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasword.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasword.Location = new System.Drawing.Point(468, 243);
            this.lblPasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(120, 79);
            this.lblPasword.TabIndex = 2;
            this.lblPasword.Text = "Password";
            this.lblPasword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(413, 228);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(252, 22);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(413, 353);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(252, 22);
            this.txtPasword.TabIndex = 5;
            this.txtPasword.UseSystemPasswordChar = true;
            this.txtPasword.TextChanged += new System.EventHandler(this.txtPasword_TextChanged);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(182, 425);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(234, 55);
            this.btnInicioSesion.TabIndex = 6;
            this.btnInicioSesion.Text = "Inicio Sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(603, 425);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(219, 55);
            this.btnCrearCuenta.TabIndex = 7;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenta.Location = new System.Drawing.Point(367, 25);
            this.lblRenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(330, 32);
            this.lblRenta.TabIndex = 8;
            this.lblRenta.Text = "Renta De Equipo Pesado";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 588);
            this.Controls.Add(this.lblRenta);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblPasword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.LblInicioSesion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInicioSesion";
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInicioSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblRenta;
    }
}

