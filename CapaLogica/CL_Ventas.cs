using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDB;

namespace CapaLogica
{
    public class CL_Ventas
    {

        CD_Farmacia consulta = new CD_Farmacia();

        public DataTable mostrarVentas()
        {

            DataTable tablaVentas = new DataTable();

            tablaVentas = consulta.mostrarVentas();
            
            return tablaVentas;
        }


        public void InsertarNuevaVenta(string fecha, string cantidad, string IdEmpleado, string IdCliente, string IdProducto)
        {
            consulta.InsertarVenta(fecha, int.Parse(cantidad), int.Parse(IdEmpleado), int.Parse(IdCliente), int.Parse(IdProducto));
        }

        public void EliminarVenta(string Id)
        {
            consulta.eliminarVenta(int.Parse(Id));
        }

        public void EditarVenta(string fechaVenta, string cantidad, string Id)
        {
            consulta.editarVenta(fechaVenta, int.Parse(cantidad), int.Parse(Id));
        }

    }
}
