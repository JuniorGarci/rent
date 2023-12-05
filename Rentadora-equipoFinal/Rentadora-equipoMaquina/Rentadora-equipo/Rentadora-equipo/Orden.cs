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
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
        }
        private void guardarOrden(NumericUpDown nmMaquina, TextBox txtEmpleado)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {
                if (txtEmpleado.Text != "")
                {
                    string texto = txtEmpleado.Text;
                    int numeroTexto;
                    if (Int32.TryParse(texto, out numeroTexto))
                    {
                        string Query = "insert into Ordenes(Id_Maquina, Id_Empleado)" +
                    "values('" + nmMaquina.DecimalPlaces + "','" + numeroTexto + "')";
                        SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                        comandoinsert.ExecuteNonQuery();
                        MessageBox.Show("Se Guardo Correctamente");
                        conex.cerrarConexion();
                    }
                }
                else
                {
                    string Query = "insert into Ordenes(Id_Maquina)" +
                    "values('" + nmMaquina.DecimalPlaces + "')";
                    SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                    comandoinsert.ExecuteNonQuery();
                    MessageBox.Show("Se Guardo Correctamente");
                    conex.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se logro guardar los registros, Error:" + ex.ToString());
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            guardarOrden(nmMaquina,txtEmpleado);
            DetalleOrden detalleOrden = new DetalleOrden();

            this.Hide();
            detalleOrden.Show();
        }

        private void Orden_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            this.Hide();
            home.Show();
        }
    }
}
