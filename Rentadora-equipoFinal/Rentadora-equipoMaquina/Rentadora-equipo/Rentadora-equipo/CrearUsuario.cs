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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
            CambiarTamanoTipoLetraLabel();
        }

        private void CambiarTamanoTipoLetraLabel()
        {
            lblRegistro.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            lblCorreo.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            lblClave.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            lblHabilitado.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            lblCreado.Font = new Font("Times New Roman", 12, FontStyle.Regular);

           // lblCorreo.Font = new Font("Times New Roman", 12, FontStyle.Regular);

            //lblContrasenia.Font = new Font("Times New Roman", 12, FontStyle.Regular);


            
        }
        //metodo para guardar datos de clientes
        private void guardarClientes(TextBox txtCorreo, TextBox txtClave, TextBox txtCreado, TextBox txtHabilitado , ComboBox cboPersona)
        {
            Clases.CConexion conex = new CConexion();
            try
            {
                string Query = "insert into Clientes( Correo, Clave, Creado, Habilitado , Id_Persona)" + "values('" + txtCorreo.Text +"','"+ txtClave.Text+"','"+txtCreado.Text+"','"+txtHabilitado.Text+"','" + cboPersona.SelectedIndex + "')";
                
                SqlCommand comandoinsert = new SqlCommand(Query,conex.establecerConexion());
                comandoinsert.ExecuteNonQuery();
                MessageBox.Show("Se Guardo Correctamente");
                conex.cerrarConexion();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(" No se logro guardar los registros, Error:" + ex.ToString());
            }
        }
        // Obtener las Personas
        public class Personas
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARPERSONACOMBOBX()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARPERSONAS", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        Personas personas = new Personas(); 



        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            // cargar departamentos
            cboPersona.DataSource = personas.CARGARPERSONACOMBOBX();
            cboPersona.DisplayMember = "Personas";
            cboPersona.ValueMember = "Id_Persona";
        }

      

        
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            guardarClientes(txtCorreo,txtClave,txtCreado,txtHabilitado, cboPersona);

            frmInicioSesion frminiciSesion = new frmInicioSesion();

            this.Hide();
            frminiciSesion.Show();
        }
    }

}
