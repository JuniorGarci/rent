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
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }
        // metodo para agregar recibos
        private void agregarPersonas(TextBox txtIdRecibo, TextBox txtIdCliente, TextBox txtIdOrden, DateTimePicker dtFechaAlquiler, DateTimePicker dtFechaDevoluvion, TextBox txtNumRecibo, TextBox txtEstadoRecibo)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {
                string Query = "insert into Recibo(Id_Recibo,Id_Cliente,Id_Orden,Fecha_Alquiler,Fecha_Devolucion,Estadp_Recibo,Numero_Recibo)" + "values('" + txtIdRecibo.Text + "','" + txtIdCliente.Text + "','" + txtIdOrden + "','" + dtFechaAlquiler + "','" + dtFechaDevolucion + "','" + txtNumRecibo + "','"+ txtEstadoRecibo.Text +"')";
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recibo_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearRecibo_Click(object sender, EventArgs e)
        {

        }
    }
}
