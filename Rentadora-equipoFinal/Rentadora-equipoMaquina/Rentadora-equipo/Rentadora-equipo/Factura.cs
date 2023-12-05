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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        // clase cargar sucursales
        public class Sucursal
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARSUCURSALES()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARSUCURSALES", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable suc = new DataTable();
                da.Fill(suc);
                return suc;
            }
        }
        public class PuntoEmision
        {
            private Clases.CConexion conex = new Clases.CConexion();
            public DataTable CARGARPUNTOEMISION()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARPUNTOEMISION", conex.establecerConexion());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable punto = new DataTable();
                da.Fill(punto);
                return punto;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        // variables a utilizar en el load
        Sucursal suc = new Sucursal();
        PuntoEmision punto = new PuntoEmision();
        private void Factura_Load(object sender, EventArgs e)
        {
            
            // cargar sucursak
            cboSucursal.DataSource = suc.CARGARSUCURSALES();
            cboSucursal.DisplayMember = "Sucursal";
            cboSucursal.ValueMember = "Id_Sucursal";
            // cargar PUNTO EMISION
            cboPuntoEmision.DataSource = punto.CARGARPUNTOEMISION();
            cboPuntoEmision.DisplayMember = "Num_Punto_Emision";
            cboPuntoEmision.ValueMember = "Id_Punto_Emision";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
