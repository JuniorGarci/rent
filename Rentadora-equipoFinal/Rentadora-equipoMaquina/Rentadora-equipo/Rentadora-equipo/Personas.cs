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
    public partial class frmPersonas : Form
    {
        public frmPersonas()
        {
            InitializeComponent();
        }
        //METODO DE AGREGAR PERSONAS
        private void agregarPersonas( TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido, TextBox txtIdentidad, ComboBox cboSexo, ComboBox cboDireccion)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {
                string Query = "insert into Personas(Primer_Nombre, Segundo_Nombre,Primer_Apellido,Segundo_Apellido, Identidad,  Id_Sexo, Id_Direccion)" + "values('"  + txtPrimerNombre.Text + "','" + txtSegundoNombre.Text + "','" + txtPrimerApellido.Text + "','" + txtSegundoApellido.Text + "','" + txtIdentidad.Text + "','"+cboSexo.SelectedIndex+"','"+cboDireccion.SelectedIndex+"')";
                SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                comandoinsert.ExecuteNonQuery();
                MessageBox.Show("Se Guardo Correctamente");
                conex.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se logro guardar los registros, Error:" + ex.ToString());
            }
        }
        // clase sexo
        public class Sexo
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARSEXO()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARSEXO", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        Sexo sexo = new Sexo();

        public class Direccion
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARDIRECCION()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARDIRECCION", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        Direccion direccion = new Direccion();


        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            this.Hide();
            frmCrearUsuario.Show();

            agregarPersonas(txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido,txtIdentidad, cboSexo, cboDireccion);

           
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            // cargar sexos
            cboSexo.DataSource = sexo.CARGARSEXO();
            cboSexo.DisplayMember = "Nombre";
            cboSexo.ValueMember = "Id_Sexo";
            //Cargar Direcciones

            cboDireccion.DataSource = direccion.CARGARDIRECCION();
            cboDireccion.DisplayMember = "Col_Aldea";
            cboDireccion.ValueMember = "Id_Direccion";
        }

        private void irUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmUsuario = new frmCrearUsuario();

            this.Hide();
            frmUsuario.Show();
        }
    }
}
