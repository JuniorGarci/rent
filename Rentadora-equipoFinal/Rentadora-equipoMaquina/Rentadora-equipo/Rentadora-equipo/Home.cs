using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentadora_equipo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Factura Factura = new Factura();

            this.Hide();
            Factura.Show();
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();

            this.Hide();
            maquina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicio = new frmInicioSesion();

            this.Hide();
            frmInicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orden frmOrden = new Orden();
            this.Hide();
            frmOrden.Show();
        }
    }
}
