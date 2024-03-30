using CapaDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Clientes
    {

        CD_Farmacia consulta = new CD_Farmacia();

        public DataTable mostrarClientes()
        {
            DataTable tablaCliente = new DataTable();

            return tablaCliente = consulta.mostrarClientes();
        }

        public void InsertarClientes(string nombre, string dni, string tel, string obrasocial, string direc)
        {
            consulta.InsertarCliente(nombre, int.Parse(dni),int.Parse(tel),obrasocial,direc);
        }

        public void EditarClientes(string nombreCliente, string dniCliente, string telCliente, string obraSocial, string direCliente, string Id)
        {
            consulta.editarCliente(nombreCliente, int.Parse(dniCliente), int.Parse(telCliente), obraSocial, direCliente, int.Parse(Id));
        }

        public void EliminarClientes(string Id)
        {
            consulta.eliminarCliente(int.Parse(Id));
        }


    }
}
