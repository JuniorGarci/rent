
namespace Rentadora_equipo
{
    partial class Orden
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
            this.Id_Maquina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nmMaquina = new System.Windows.Forms.NumericUpDown();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenes";
            // 
            // Id_Maquina
            // 
            this.Id_Maquina.AutoSize = true;
            this.Id_Maquina.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Maquina.Location = new System.Drawing.Point(25, 79);
            this.Id_Maquina.Name = "Id_Maquina";
            this.Id_Maquina.Size = new System.Drawing.Size(93, 24);
            this.Id_Maquina.TabIndex = 1;
            this.Id_Maquina.Text = "Maquina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Detalle_Orden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmMaquina
            // 
            this.nmMaquina.Location = new System.Drawing.Point(175, 81);
            this.nmMaquina.Name = "nmMaquina";
            this.nmMaquina.Size = new System.Drawing.Size(120, 22);
            this.nmMaquina.TabIndex = 6;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(175, 124);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(120, 22);
            this.txtEmpleado.TabIndex = 7;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Lime;
            this.btnAtras.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(585, 176);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(201, 66);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 334);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.nmMaquina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_Maquina);
            this.Controls.Add(this.label1);
            this.Name = "Orden";
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMaquina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_Maquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmMaquina;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnAtras;
    }
}