using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDB;

namespace CapaLogica
{
    public class CL_Productos
    {

        CD_Farmacia consulta = new CD_Farmacia();

        public DataTable mostrarProductos()
        {
            DataTable tablaProducto = new DataTable();

            return tablaProducto = consulta.mostrarProductos();

        }

        public DataTable mostrarPrecios()
        {
            DataTable tablaPrecio = new DataTable();

            return tablaPrecio = consulta.mostrarPrecios();

        }


        public void InsertarProducto(string nombre, string precio, string fechavec, string marca)
        {
            consulta.InsertarProducto(nombre, int.Parse(precio), fechavec, marca);
        }

        public void EditarProducto(string nombreProducto, string precioProducto, string fechaVec, string marcaProducto, string Id)
        {
            consulta.editarProducto(nombreProducto, int.Parse(precioProducto), fechaVec, marcaProducto, int.Parse(Id));
        }

        public void EliminarProducto(string Id)
        {
            consulta.eliminarProducto(int.Parse(Id));
        }

    }
}
