using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapPrese
{
    public partial class frmNosotros : Form
    {
        public frmNosotros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Form frmInicioFarmacia = new frmInicioFarmacia();
            // frmInicioFarmacia.Show();
            // this.Hide();
        }

        private void picVolver_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }


        private void picSiguiente_Click(object sender, EventArgs e)
        {
            if (picGatti.Visible == true)
            {
                picEsper.Visible = true;
                picMatias.Visible = false;
                picisma.Visible = false;
                picGatti.Visible = false;

            }
            else if (picEsper.Visible == true)
            {
                picEsper.Visible = false;
                picMatias.Visible = true;
                picisma.Visible = false;
                picGatti.Visible = false;

            }
            else if (picMatias.Visible == true)
            {
                picEsper.Visible = false;
                picMatias.Visible = false;
                picisma.Visible = true;
                picGatti.Visible = false;
            }
            else if (picisma.Visible == true)
            {
                picEsper.Visible = false;
                picMatias.Visible = false;
                picisma.Visible = false;
                picGatti.Visible = true;
            }
        }
    }
}
