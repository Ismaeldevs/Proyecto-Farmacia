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
    public partial class frmProductos : Form
    {

        public frmProductos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CL_Productos productos = new CL_Productos();

            dgvProductos.DataSource = productos.mostrarProductos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CL_Productos productos = new CL_Productos();

            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text; 
            string fechavec = txtFechaVec.Text;
            string marca = txtMarca.Text;

            if(nombre == "" || precio == "" || fechavec == "" || marca == "")
            {
                MessageBox.Show("Campos Incompletos, complete los campos por favor.");
            } else
            {
                productos.InsertarProducto(nombre, precio, fechavec, marca);
            }

            ListarProductos();
            LimpiarCampos();
        }

        public void ListarProductos()
        {
            CL_Productos productos = new CL_Productos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos.mostrarProductos();
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtFechaVec.Clear();
            txtMarca.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                CL_Productos producto = new CL_Productos();

                string Id = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();

                producto.EliminarProducto(Id);

                MessageBox.Show("Producto eliminado con éxito!", "PRODUCTO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProductos();

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

            txtNombre.Text = dgvProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells["PrecioProducto"].Value.ToString();
            txtFechaVec.Text = dgvProductos.CurrentRow.Cells["FechaVec"].Value.ToString();
            txtMarca.Text = dgvProductos.CurrentRow.Cells["MarcaProducto"].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombre.Text;
            string precioProducto = txtPrecio.Text;
            string fechaVec = txtFechaVec.Text;
            string marcaProducto = txtMarca.Text;

            if (nombreProducto == "" || precioProducto == "" || fechaVec == "" || marcaProducto == "")
            {
                MessageBox.Show("Campos incompletos, por favor complete los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CL_Productos producto = new CL_Productos();

                string Id = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();

                producto.EditarProducto(nombreProducto, precioProducto, fechaVec, marcaProducto, Id);

                MessageBox.Show("Cliente actualizado con éxito!", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarProductos();
                LimpiarCampos();

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
