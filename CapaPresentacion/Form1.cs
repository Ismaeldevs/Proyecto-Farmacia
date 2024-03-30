using CapPrese;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmSistema : Form
    {

        public frmSistema()
        {
            InitializeComponent();
        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();

            clientes.Show();

            this.Hide();
        }

        private void picProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();

            productos.Show();

            this.Hide();
        }

        private void picVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();

            ventas.Show();

            this.Hide();
        }

        private void picNuevaVenta_Click(object sender, EventArgs e)
        {
            frmnuevaVenta frmVenta = new frmnuevaVenta(); 

            frmVenta.Show();

            this.Hide();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();

            frmEmpleados.Show();

            this.Hide();
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
            tmHorario.Enabled = true;
        }

        private void tmHorario_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss"); 
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void picQSomos_Click(object sender, EventArgs e)
        {
            frmNosotros nosotros = new frmNosotros();

            nosotros.Show();

            this.Hide();
        }
    }
}
