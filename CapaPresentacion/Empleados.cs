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
    public partial class frmEmpleados : Form
    {

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CL_Empleados empleado = new CL_Empleados();

            dgvEmpleados.DataSource = empleado.mostrarEmpleados();
        }

        private void picVolver_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CL_Empleados empleado = new CL_Empleados();

            string nombreEmpleado = txtNomyApe.Text;
            string dniEmpleado = txtDni.Text;
            string telEmpleado = txtTel.Text;
            string direEmpleado = txtDire.Text;

            if(nombreEmpleado == "" ||  dniEmpleado == "" || telEmpleado == "" || direEmpleado == "")
            {
                MessageBox.Show("ERROR AL INTENTAR AÑADIR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                empleado.insertarEmpleado(nombreEmpleado, dniEmpleado, telEmpleado, direEmpleado);

                MessageBox.Show("Empleado añadido con éxito!", "EMPLEADO AÑADIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                listarEmpleados();
                limpiarCampos();
            }
        }

        public void listarEmpleados()
        {
            CL_Empleados empleado = new CL_Empleados();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleado.mostrarEmpleados();
        }

        public void limpiarCampos()
        {
            txtNomyApe.Clear();
            txtDni.Clear();
            txtTel.Clear();
            txtDire.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                CL_Empleados empleado = new CL_Empleados();

                string Id = dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString();

                empleado.EliminarEmpleado(Id);

                MessageBox.Show("Empleado eliminado con éxito!", "EMPLEADO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarEmpleados();

            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
            btnEliminar.Visible = false;
            btnActualizar.Visible = false;

            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

            txtNomyApe.Text = dgvEmpleados.CurrentRow.Cells["NombreEmpleado"].Value.ToString();
            txtDni.Text = dgvEmpleados.CurrentRow.Cells["DniEmpleado"].Value.ToString();
            txtTel.Text = dgvEmpleados.CurrentRow.Cells["TelEmpleado"].Value.ToString();
            txtDire.Text = dgvEmpleados.CurrentRow.Cells["DireEmpleado"].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtNomyApe.Text;
            string dniEmpleado = txtDni.Text;
            string telEmpleado = txtTel.Text;
            string direEmpleado = txtDire.Text;

            if (nombreEmpleado == "" || dniEmpleado == "" || telEmpleado == "" || direEmpleado == "")
            {
                MessageBox.Show("Campos incompletos, por favor complete los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CL_Empleados empleado = new CL_Empleados();

                string Id = dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value.ToString();

                empleado.EditarEmpleado(nombreEmpleado, dniEmpleado, telEmpleado, direEmpleado, Id);

                MessageBox.Show("Cliente actualizado con éxito!", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listarEmpleados();
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
    }
}
