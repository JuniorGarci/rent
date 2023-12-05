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
    public partial class Maquina : Form
    {
        public Maquina()
        {
            InitializeComponent();

        }
        //metodo para agregar maquinaria 

        private void guardarMaquina(TextBox txtNombre, TextBox txtDecrip, DateTimePicker dateAdqui, NumericUpDown CostoMaquinaria,
            NumericUpDown CostoRenta, TextBox txtSeguro, TextBox txtPlaca,TextBox txtPotencia, TextBox txtSerie, NumericUpDown PrecioHora, ComboBox cboMarca,
            ComboBox cboCategoria, ComboBox cboEstado, ComboBox cboCombustible, ComboBox cboSubcategoria, ComboBox cboModelo, ComboBox cboColor,
            ComboBox cboOrigen)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {
                string Query = "insert into Maquina(Nombre, Descripcion, Fecha_Adquisicion, Costo_Maquina, Costo_Renta, Seguro, Placa, Potencia, Serie, PrecioPorHora, Id_Marca, Id_Combustible, Id_Categoria, Id_Estado)" +
                    "values('" + txtNombre.Text + "','" + txtDescrip.Text + "','" + dateAdqui.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + CostoMaquinaria.Value + "','" + CostoRenta.Value + "','" + txtSeguro.Text + "','" + txtPlaca.Text + "','" + txtPotencia.Text + "','" +
                    txtSerie.Text + "','" + PrecioHora.Value + "','" + cboMarca.SelectedIndex + "','" + cboCombustible.SelectedIndex + "','" + cboCategoria.SelectedIndex + "','" + cboEstado.SelectedIndex + "')";
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
        
        // clase cargar marca
        public class Marca
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARMARCA()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARMARCA", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable ma= new DataTable();
                da.Fill(ma);
                return ma;
            }
        }
        //CLASE PARA CARGAR CATEGORIA
        public class Categoria
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARCATEGORIA()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCATEGORIA", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable cat = new DataTable();
                da.Fill(cat);
                return cat;
            }
        }
        // CLASE CARGAR ESTADOS
        public class Estado
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARESTADO()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARESTADO", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable est = new DataTable();
                da.Fill(est);
                return est;
            }
        }
        // clase cargar origen
        public class Origen
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARORIGEN()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARORIGEN", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable or = new DataTable();
                da.Fill(or);
                return or;
            }
        }
        //cargar subcategoria
        public class Subcategoria
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARSUBCATEGORIA()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARSUBCATEGORIA", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable subcat = new DataTable();
                da.Fill(subcat);
                return subcat;
            }
        }
        //cargar Combustible
        public class Combustible
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARCOMBUSTIBLE()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCOMBUSTIBLE", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable combus = new DataTable();
                da.Fill(combus);
                return combus;
            }
        }
        // variables a utilizar en el load
        Marca ma= new Marca();
        Categoria cat = new Categoria();
        Estado est = new Estado();
        Origen or = new Origen();
        Subcategoria subcat = new Subcategoria();
        Combustible combus = new Combustible();
        private void Maquina_Load(object sender, EventArgs e)
        {
            // cargar marca
            cboMarca.DataSource = ma.CARGARMARCA();
            cboMarca.DisplayMember = "Marca";
            cboMarca.ValueMember = "Id_Marca";
            // cargar categorias
            cboCategoria.DataSource = cat.CARGARCATEGORIA();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "Id_Categoria";
            // cargar estado
            cboEstado.DataSource = est.CARGARESTADO();
            cboEstado.DisplayMember = "Estado";
            cboEstado.ValueMember = "Id_Estado";
            // cargar origen
            cboOrigen.DataSource = or.CARGARORIGEN();
            cboOrigen.DisplayMember = "Nombre";
            cboOrigen.ValueMember = "Id_Origen";
            // cargar subcategoria
            cboSubcategoria.DataSource = subcat.CARGARSUBCATEGORIA();
            cboSubcategoria.DisplayMember = "Nombre";
            cboSubcategoria.ValueMember = "Id_Subcat";
            // cargar combustible
            cboCombustible.DataSource = combus.CARGARCOMBUSTIBLE();
            cboCombustible.DisplayMember = "Nombre";
            cboCombustible.ValueMember = "Id_Combustible";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            this.Hide();
            home.Show();
        }

        private void GuardarDatos_Click(object sender, EventArgs e)
        {
            guardarMaquina(txtNombre, txtDescrip, dateAdqui, CostoMaquinaria, CostoRenta, txtSeguro, txtPlaca, txtPotencia, txtSerie, PrecioHora, cboMarca, cboCombustible, cboCategoria,cboEstado, cboSubcategoria, cboModelo, cboColor, cboOrigen);
        }
    }
} 




