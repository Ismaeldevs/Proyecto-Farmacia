using CapaLogica;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void picVolver_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CL_Clientes clientes = new CL_Clientes();

            dgvClientes.DataSource = clientes.mostrarClientes();
            // listarClientes();
            // limpiarCampos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CL_Clientes clientes = new CL_Clientes();

            string nombre = txtNomyApe.Text;
            string dni = txtDni.Text;
            string tel = txtTel.Text;
            string obrasocial = txtObraSocial.Text;
            string direc = txtDirec.Text;

            if (nombre == "" || dni == "" || tel == "" || obrasocial == "" || direc == "")
            {
                MessageBox.Show("Campos incompletos, complete todos los datos por favor.", "ERROR!");
            } else
            {
                clientes.InsertarClientes(nombre, dni, tel, obrasocial, direc);
                MessageBox.Show("Cliente añadido con éxito!", "CLIENTE AÑADIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            listarClientes();
            limpiarCampos();
        }

        public void listarClientes()
        {
            CL_Clientes clientes = new CL_Clientes();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes.mostrarClientes();
        }

        public void limpiarCampos()
        {
            txtNomyApe.Clear();
            txtDni.Clear();
            txtTel.Clear();
            txtObraSocial.Clear();
            txtDirec.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;

            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

            txtNomyApe.Text = dgvClientes.CurrentRow.Cells["NombreCliente"].Value.ToString();
            txtDni.Text = dgvClientes.CurrentRow.Cells["DniCliente"].Value.ToString();
            txtTel.Text = dgvClientes.CurrentRow.Cells["TelCliente"].Value.ToString();
            txtObraSocial.Text = dgvClientes.CurrentRow.Cells["ObraSocial"].Value.ToString();
            txtDirec.Text = dgvClientes.CurrentRow.Cells["DireCliente"].Value.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNomyApe.Text;
            string dniCliente = txtDni.Text;
            string telCliente = txtTel.Text;
            string obraSocial = txtObraSocial.Text;
            string direCliente = txtDirec.Text;
            
            if(nombreCliente == "" || dniCliente == "" || telCliente == "" || obraSocial == "" || direCliente == "")
            {
                MessageBox.Show("Campos incompletos, por favor complete los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                CL_Clientes cliente = new CL_Clientes();

                string Id = dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString();

                cliente.EditarClientes(nombreCliente, dniCliente, telCliente, obraSocial, direCliente, Id);

                MessageBox.Show("Cliente actualizado con éxito!", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listarClientes();
                limpiarCampos();

                btnAceptar.Visible = false;
                btnCancelar.Visible = false;

                btnIngresar.Visible = true;
                btnActualizar.Visible = true;
                btnEliminar.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;

            btnActualizar.Visible = true;
            btnIngresar.Visible = true;
            btnEliminar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0) 
            { 
                CL_Clientes cliente = new CL_Clientes();

                string Id = dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString();

                cliente.EliminarClientes(Id);

                MessageBox.Show("Cliente eliminado con éxito!", "ELIMINACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarClientes();

            } else
            {
                MessageBox.Show("Por favor seleccione una fila!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
