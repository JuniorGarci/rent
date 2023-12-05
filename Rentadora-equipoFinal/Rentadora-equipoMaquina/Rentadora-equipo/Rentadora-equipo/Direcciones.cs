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
    public partial class frmDirecciones : Form
    {
        public frmDirecciones()
        {
            InitializeComponent();
        }
        // metodo para agregar direcciones
        private void guardarDirecciones(TextBox txtCalle, TextBox txtColonia, TextBox txtNumeroCasa, ComboBox cboMunicipio)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {

                string Query = "insert into Direccion(Col_Aldea, Calle, Numero_Casa,Id_Municipio)" + "values('" + txtCalle.Text + "','" + txtColonia.Text + "','" + txtNumeroCasa.Text + "','"+ cboMunicipio.SelectedIndex +"')";
                SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                comandoinsert.ExecuteNonQuery();
                MessageBox.Show("Se Guardo Correctamente");
                conex.cerrarConexion();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(" No se logro guardar los registros, Error:" + ex.ToString());
            }
        }
        public class Departamento
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARDEPARTAMENTOCOMBOBOX()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARDEPARTAMENTOCOMBOBOX", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public class Municipio
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARMUNICIPIO()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARMUNICIPIO", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        Departamento dep = new Departamento();
        Municipio muni = new Municipio();
        private void LblInicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void frmDirecciones_Load(object sender, EventArgs e)
        {
            // cargar departamentos
            cboDepartamento.DataSource = dep.CARGARDEPARTAMENTOCOMBOBOX();
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.ValueMember = "Id_Departamento";
            //cargar municipios
            cboMunicipio.DataSource = muni.CARGARMUNICIPIO();
            cboMunicipio.DisplayMember = "Municipio";
            cboMunicipio.ValueMember = "Id_Municipio";
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            frmPersonas frmPersonas = new frmPersonas();

            this.Hide();
            frmPersonas.Show();

        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            guardarDirecciones(txtColonia, txtCalle,txtNumeroCasa,cboMunicipio);
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
