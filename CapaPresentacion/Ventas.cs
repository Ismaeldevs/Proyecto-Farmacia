using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {

        CL_Ventas ventas = new CL_Ventas();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void picVolver_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ventas.mostrarVentas();
        }
    }
}
