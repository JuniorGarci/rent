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
    public partial class DetalleOrden : Form
    {
        public DetalleOrden()
        {
            InitializeComponent();
        }
        // METODO GUARDAR detalle orden
        private void guardarDetalleOrden(TextBox txtOrden, TextBox txtCombo, TextBox txtRenta, TextBox txtCliente, TextBox txtHoraRentada, DateTimePicker dtFechaInicio, DateTimePicker dtFechaFinal, TextBox txtDepositoInicial)
        {
            Clases.CConexion conex = new Clases.CConexion();
            try
            {

                if (txtOrden.Text != "")
                {
                    string texto = txtOrden.Text;
                    int ordenTexto;

                    if (Int32.TryParse(texto, out ordenTexto))
                    {


                        string RentaText = txtRenta.Text;
                        int RentaNum;
                        if (Int32.TryParse(RentaText, out RentaNum))
                        {

                            string ClienteText = txtCliente.Text;
                            int ClienteNum;

                            if (Int32.TryParse(ClienteText, out ClienteNum))
                            {
                                string HoraRentatext = txtHoraRentada.Text;
                                int HoraRentaNum;
                                if (Int32.TryParse(HoraRentatext, out HoraRentaNum))
                                {


                                    string Query = "insert into Detalle_Orden(Id_Orden, Id_Renta,Id_Cliente,Horas_Rentadas,Fecha_Inicio,Fecha_Final,Deposito_Inicial)" +
                                     "values('" + ordenTexto + "','" + RentaNum + "','" + ClienteNum + "','" + HoraRentaNum + "','" + dtFechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dtFechaFinal.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','"+txtDepositoInicial.Text+"')";
                                    SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                                    comandoinsert.ExecuteNonQuery();
                                    MessageBox.Show("Se Guardo Correctamente");
                                    conex.cerrarConexion();



                                }
                            }
                        }
                    }
                }
                else
                {
                    string texto = txtCombo.Text;
                    int comboTexto;

                    if (Int32.TryParse(texto, out comboTexto))
                    {


                        string RentaText = txtRenta.Text;
                        int RentaNum;
                        if (Int32.TryParse(RentaText, out RentaNum))
                        {

                            string ClienteText = txtCliente.Text;
                            int ClienteNum;

                            if (Int32.TryParse(ClienteText, out ClienteNum))
                            {
                                string HoraRentatext = txtHoraRentada.Text;
                                int HoraRentaNum;
                                if (Int32.TryParse(HoraRentatext, out HoraRentaNum))
                                {

                                    string Query = "insert into Detalle_Orden(Id_Combo, Id_Renta,Id_Cliente,Horas_Rentadas,Fecha_Inicio,Fecha_Final,Deposito_Inicial)" +
                                     "values('" + comboTexto + "','" + RentaNum + "','" + ClienteNum + "','" + HoraRentaNum + "','" + dtFechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dtFechaFinal.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','"+txtDepositoInicial.Text+"')";
                                    SqlCommand comandoinsert = new SqlCommand(Query, conex.establecerConexion());
                                    comandoinsert.ExecuteNonQuery();
                                    MessageBox.Show("Se Guardo Correctamente");
                                    conex.cerrarConexion();



                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se logro guardar los registros, Error:" + ex.ToString());
            }
        }
        private void DetalleOrden_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDetalleOrden(txtOrden, txtCombo, txtRenta, txtIdCliente, txtHoraRentada, dtFechaInicio, dtFechaFinal, txtDepositoInicial);
            Factura factura = new Factura();
            this.Hide();
            factura.Show();
        }
    }
}
