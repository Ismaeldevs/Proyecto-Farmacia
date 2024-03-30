using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDB;

namespace CapaLogica
{
    public class CL_Empleados
    {
        CD_Farmacia consulta = new CD_Farmacia();

        public DataTable mostrarEmpleados()
        {
            DataTable tablaEmpleados = new DataTable();

           return tablaEmpleados = consulta.mostrarEmpleados();
        }

        public void insertarEmpleado(string nombreEmpleado, string dniEmpleado, string telEmpleado, string direEmpleado)
        {
            consulta.InsertarEmpleado(nombreEmpleado, int.Parse(dniEmpleado), int.Parse(telEmpleado), direEmpleado);
        }

        public void EditarEmpleado(string nombreEmpleado, string dniEmpleado, string telEmpleado, string direEmpleado, string Id)
        {
            consulta.editarEmpleado(nombreEmpleado, int.Parse(dniEmpleado), int.Parse(telEmpleado), direEmpleado, int.Parse(Id));
        }

        public void EliminarEmpleado(string Id)
        {
            consulta.eliminarEmpleado(int.Parse(Id));
        }
    }
}
