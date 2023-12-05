using Rentadora_equipo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentadora_equipo
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            CambiarTamanoTipoLetraLabel();

            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();

            


        }

        private void CambiarTamanoTipoLetraLabel()
        {
            lblRenta.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            LblInicioSesion.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            lblUsuario.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            lblPasword.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            txtCorreo.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            txtPasword.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            btnInicioSesion.Size = new Size(150, 40);
            
            btnInicioSesion.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            btnCrearCuenta.Size = new Size(150, 40);

            btnCrearCuenta.Font = new Font("Times New Roman", 12, FontStyle.Bold);
        }

        public object FontUnit { get; private set; }

        

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtPasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            frmDirecciones frmDirecciones = new frmDirecciones();

            this.Hide();
            frmDirecciones.Show();

           

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string clave = txtPasword.Text.Trim();


            CConexion cConexion = new CConexion();

            if (cConexion.VerificarCredenciales(correo, clave))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí puedes redirigir a la siguiente ventana o realizar otras acciones
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifique sus credenciales.");
            }
            Home home = new Home();

            this.Hide();
            home.Show();
        }



    }
}
