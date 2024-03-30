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
    public partial class frmnuevaVenta : Form
    {

        public frmnuevaVenta()
        {
            InitializeComponent();

        }

        private void nuevaVenta_Load(object sender, EventArgs e)
        {
            CL_Ventas nuevaventa = new CL_Ventas();

            dgvNuevaVenta.DataSource = nuevaventa.mostrarVentas();
            mostrarEmpleado();
            mostrarCliente();
            mostrarProducto();


        }

        private void picVolver_Click(object sender, EventArgs e)
        {
            frmSistema principal = new frmSistema();

            principal.Show();

            this.Hide();
        }


        public void mostrarEmpleado()
        {
            CL_Empleados empleado = new CL_Empleados();

            cmbEmpleado.DataSource = empleado.mostrarEmpleados();
            cmbEmpleado.ValueMember = "IdEmpleado";
            cmbEmpleado.DisplayMember = "NombreEmpleado";
        }

        public void mostrarCliente()
        {
            CL_Clientes cliente = new CL_Clientes();

            cmbCliente.DataSource = cliente.mostrarClientes();
            cmbCliente.ValueMember = "IdCliente";
            cmbCliente.DisplayMember = "NombreCliente";
        }

        public void mostrarProducto()
        {
            CL_Productos producto = new CL_Productos();

            cmbProductos.DataSource = producto.mostrarPrecios();
            cmbPrecios.DataSource = producto.mostrarPrecios();
            cmbProductos.ValueMember = "IdProducto";
            cmbPrecios.ValueMember = "IdProducto";
            cmbProductos.DisplayMember = "NombreProducto";
            cmbPrecios.DisplayMember = "PrecioProducto";

        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            CL_Ventas nuevaventa = new CL_Ventas();

            string IdEmpleado = cmbEmpleado.SelectedValue.ToString();
            string IdCliente = cmbCliente.SelectedValue.ToString();
            string IdProducto = cmbProductos.SelectedValue.ToString();

            string fechaventa = txtFecha.Text;
            string cantidad = txtCantidad.Text;

            if (cantidad == "0" || cantidad == "" || fechaventa == "")
            {
                MessageBox.Show("Campos incompletos o mal escritos, revise por favor");

                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                lblImprimir.Visible = false;
                picTicket.Visible = false;

            } else
            {
                nuevaventa.InsertarNuevaVenta(fechaventa, cantidad, IdEmpleado, IdCliente, IdProducto);

                btnActualizar.Visible = true;
                btnEliminar.Visible = true;

                lblImprimir.Visible = true;
                picTicket.Visible = true;

                lblPreciototal.Visible = true;

                int precio = int.Parse(cmbPrecios.Text);

                int cantidadProducto = int.Parse(txtCantidad.Text);

                int total = precio * cantidadProducto;

                lblPreciototal.Text = total.ToString();
            }

            ListarVentas();
            LimpiarCampos();

        }

        public void ListarVentas()
        {

            CL_Ventas venta = new CL_Ventas();

            dgvNuevaVenta.DataSource = null;
            dgvNuevaVenta.DataSource = venta.mostrarVentas();

        }

        public void LimpiarCampos()
        {

            txtFecha.Clear();
            txtCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvNuevaVenta.SelectedRows.Count > 0) 
            {
                CL_Ventas venta = new CL_Ventas();

                string Id = dgvNuevaVenta.CurrentRow.Cells["IdVenta"].Value.ToString();

                venta.EliminarVenta(Id);

                MessageBox.Show("Venta eliminada con éxito!", "VENTA ELIMINADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarVentas();
            
            } else
            {
                MessageBox.Show("Por favor seleccione una fila!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnAñadir.Visible = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;

            btnAceptar.Visible = true;
            btnCancelar.Visible = true;

            txtFecha.Text = dgvNuevaVenta.CurrentRow.Cells["fechaVenta"].Value.ToString();
            txtCantidad.Text = dgvNuevaVenta.CurrentRow.Cells["CantVenta"].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fechaventa = txtFecha.Text;

            string cantidad = txtCantidad.Text;

            if (cantidad == "0" || cantidad == "" || fechaventa == "")
            {
                MessageBox.Show("Campos incompletos o mal escritos, revise por favor");

                btnActualizar.Visible = false;
                btnEliminar.Visible = false;

            } else
            {
                CL_Ventas venta = new CL_Ventas();

                string Id = dgvNuevaVenta.CurrentRow.Cells["IdVenta"].Value.ToString();

                venta.EditarVenta(fechaventa, cantidad, Id);

                MessageBox.Show("Venta actualizada con éxito!");
                ListarVentas();
                LimpiarCampos();

                btnAñadir.Visible = true;
                btnActualizar.Visible = true;
                btnEliminar.Visible = true;

                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            btnCancelar.Visible = false;
            btnAceptar.Visible = false;

            btnAñadir.Visible = true;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;

        }

        private void picTicket_Click(object sender, EventArgs e)
        {
             CL_Ventas venta = new CL_Ventas();

            frmTicket ticket = new frmTicket();

            if (dgvNuevaVenta.SelectedRows.Count > 0)
            {

                string IdProducto = dgvNuevaVenta.CurrentRow.Cells["IdProducto"].Value.ToString();
                string IdEmpleado = dgvNuevaVenta.CurrentRow.Cells["IdEmpleado"].Value.ToString();

                ticket.lblProductoID.Text = IdProducto;
                ticket.lblProducto.Text = cmbProductos.Text;

                ticket.lblnombreCliente.Text = cmbCliente.Text;
                ticket.lblNombreVendedor.Text = cmbEmpleado.Text;
                ticket.lblVendedorID.Text = $"({IdEmpleado})";


                ticket.lblPrecioProducto.Text = cmbPrecios.Text;
                ticket.lblPrecioTotal.Text = lblPreciototal.Text;



                ticket.Show();

                this.Hide();
            }

        }
    }
}
