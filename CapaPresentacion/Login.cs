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
using System.Data.SqlClient;
using System.Net;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;

            if(nombre == "" || dni == "" || dni == "0")
            {
                MessageBox.Show("Complete los campos por favor!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                login(nombre, int.Parse(dni));
            }

        }

        public void login(string nombre, int dni)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-NKI4B61;Initial Catalog=FarmaciaProyect;Integrated Security=True;");

            conexion.Open();

            SqlCommand cmd = new SqlCommand("select NombreEmpleado,DniEmpleado from Empleado where NombreEmpleado='" + nombre + "' and DniEmpleado='" + dni + "'", conexion);

            SqlDataReader lector = cmd.ExecuteReader();

            if(lector.Read())
            {
                frmSistema principal = new frmSistema();

                MessageBox.Show($"Bienvenido {nombre} [EMPLEADO]", "LOGIN CORRECTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                principal.Show();

                this.Hide();

            } else
            {
                MessageBox.Show("Nombre o DNI incorrecto, intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
