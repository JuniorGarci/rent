
namespace Rentadora_equipo
{
    partial class frmCrearUsuario
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtHabilitado = new System.Windows.Forms.TextBox();
            this.txtCreado = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblRegistro.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(340, 7);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(80, 17);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registrate";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(199, 154);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(60, 21);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(206, 219);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 21);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitado.Location = new System.Drawing.Point(206, 281);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(88, 21);
            this.lblHabilitado.TabIndex = 3;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.Location = new System.Drawing.Point(206, 356);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(63, 21);
            this.lblCreado.TabIndex = 4;
            this.lblCreado.Text = "Creado";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(202, 190);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(234, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(202, 250);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(234, 20);
            this.txtClave.TabIndex = 7;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtHabilitado
            // 
            this.txtHabilitado.Location = new System.Drawing.Point(202, 324);
            this.txtHabilitado.Name = "txtHabilitado";
            this.txtHabilitado.Size = new System.Drawing.Size(234, 20);
            this.txtHabilitado.TabIndex = 8;
            // 
            // txtCreado
            // 
            this.txtCreado.Location = new System.Drawing.Point(202, 396);
            this.txtCreado.Name = "txtCreado";
            this.txtCreado.Size = new System.Drawing.Size(234, 20);
            this.txtCreado.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(496, 110);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(141, 50);
            this.btnCrearUsuario.TabIndex = 13;
            this.btnCrearUsuario.Text = "Guardar Datos";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(496, 190);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 50);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Agregar datos del Usuario";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPersona.Location = new System.Drawing.Point(202, 85);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(92, 21);
            this.lblIdPersona.TabIndex = 26;
            this.lblIdPersona.Text = "Id_Persona";
            // 
            // cboPersona
            // 
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(206, 110);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(141, 21);
            this.cboPersona.TabIndex = 27;
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 496);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtCreado);
            this.Controls.Add(this.txtHabilitado);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCreado);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblRegistro);
            this.Name = "frmCrearUsuario";
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtHabilitado;
        private System.Windows.Forms.TextBox txtCreado;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.ComboBox cboPersona;
    }
}