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
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            lblLaHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblLaFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void picAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TICKET IMPRIMIDO CON EXITO!", "OPERACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            frmnuevaVenta venta = new frmnuevaVenta();

            venta.Show();

            this.Hide();
        }
    }
}
