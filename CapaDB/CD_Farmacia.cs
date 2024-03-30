using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
namespace CapaDB
{
    public class CD_Farmacia
    {
        Conexion_DB conexion = new Conexion_DB();

        DataTable tabla = new DataTable();

        SqlCommand cmd = new SqlCommand();

        SqlDataReader lector;

        // CRUD DE CLIENTES
        public DataTable mostrarClientes()
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "listaClientes";

                cmd.CommandText = query;

                cmd.CommandType = CommandType.StoredProcedure;

                lector = cmd.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception ex)
            {

                throw ex;
            } finally
            {
                conexion.CloseConection();
            }
            return tabla;
        }


        public void InsertarCliente(string nombre, int dni, int tel, string obrasocial, string direc)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "insert into cliente (NombreCliente,DniCliente,TelCliente,ObraSocial,DireCliente) values ('" + nombre+"',"+dni+","+tel+",'"+obrasocial+"','"+direc+"')";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();


            } catch (Exception ex)
            {
                throw ex;
            } finally 
            { 
                conexion.CloseConection(); 
            }


        }


        public void editarCliente(string nombreCliente, int dniCliente, int telCliente, string obraSocial, string direCliente, int Id)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "update cliente set NombreCliente='"+nombreCliente+"',DniCliente='"+dniCliente+"',TelCliente='"+telCliente+"',ObraSocial='"+obraSocial+"',DireCliente='"+direCliente+"' where IdCliente="+Id+"";
                
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            } catch (Exception ex) 
            { 
                throw ex; 
            } finally 
            {
                conexion.CloseConection(); 
            }
        }

        public void eliminarCliente(int Id)
        {
            try 
            {
                cmd.Connection = conexion.OpenConection();

            string query = "delete from cliente where IdCliente = " + Id + "";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            } catch (Exception ex) 
            {
                throw ex;
            } finally
            {
                conexion.CloseConection(); 
            }
        }



        // CRUD PRODUCTOS
        public DataTable mostrarProductos()
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "select * from Producto";

                cmd.CommandText = query;

                lector = cmd.ExecuteReader();

                tabla.Load(lector);


            } catch (Exception ex) {
            
                throw ex;
            } finally { 
            
                conexion.CloseConection();
            }
            return tabla;
        }

        public DataTable mostrarPrecios()
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "listarProductosyPrecio";

                cmd.CommandText = query;

                cmd.CommandType = CommandType.StoredProcedure;

                lector = cmd.ExecuteReader();

                tabla.Load(lector);

            } catch (Exception ex) 
            { 
                throw ex;
            } finally 
            {
                conexion.CloseConection();
            }

            return tabla;
        }

        public void InsertarProducto(string nombre, int precio, string fechavec, string marca)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "insert into producto (NombreProducto,PrecioProducto,FechaVec,MarcaProducto) values ('" + nombre + "'," + precio + ",'" + fechavec + "','" + marca + "')";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            } catch (Exception ex) 
            { 
                throw ex;
            } finally 
            {
                conexion.CloseConection();
            }

        }

        public void eliminarProducto(int Id)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "delete from producto where IdProducto = " + Id + "";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CloseConection();
            }
        }

        public void editarProducto(string nombreProducto, int precioProducto, string fechaVec, string marcaProducto, int Id)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "update producto set NombreProducto='" + nombreProducto + "',PrecioProducto='" + precioProducto + "',FechaVec='" + fechaVec + "',MarcaProducto='" + marcaProducto + "' where IdProducto =" + Id + "";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CloseConection();
            }
        }


        // CRUD DE VENTAS y DETALLES de VENTA
        public DataTable mostrarVentas()
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "select * from Venta";

                cmd.CommandText = query;

                lector = cmd.ExecuteReader();

                tabla.Load(lector);
            }
            catch (Exception ex)
            {

                throw ex;
            } finally { 
            
                conexion.CloseConection();
            }

            return tabla;
        }

        public void InsertarVenta(string fechaventa, int cantidad, int IdEmpleado, int IdCliente, int IdProducto)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "insert into venta (fechaVenta,CantVenta,IdEmpleado,IdCliente,IdProducto) values ('" + fechaventa + "'," + cantidad + ","+IdEmpleado+", "+IdCliente+", "+IdProducto+")";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            } catch(Exception ex) 
            {
                throw ex;
            } finally
            {
                conexion.CloseConection();
            }
        }

        public void eliminarVenta(int Id)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "delete from venta where IdVenta = "+Id+"";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();


            } catch (Exception ex)
            {
                throw ex;
            } finally 
            {
            
            conexion.CloseConection();}
            }

        public void editarVenta(string fechaVenta, int cantidad, int Id) 
        {

            try 
            {

                cmd.Connection = conexion.OpenConection();

                string query = "update venta set fechaVenta='"+fechaVenta+"',CantVenta='"+cantidad+"' where IdVenta="+Id+"";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            } catch (Exception ex) 
            {
                throw ex;
            } finally 
            { 
                conexion.CloseConection();
            }


        }



        // CRUD EMPLEADOS
        public DataTable mostrarEmpleados()
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "select * from Empleado;";

                cmd.CommandText = query;

                lector = cmd.ExecuteReader();

                tabla.Load(lector);
            } catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CloseConection();
            }
            return tabla;
        }

        public void InsertarEmpleado(string nombreEmpleado, int dniEmpleado, int telEmpleado, string direEmpleado)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "insert into empleado (NombreEmpleado,DniEmpleado,TelEmpleado,DireEmpleado) values ('" + nombreEmpleado + "'," + dniEmpleado + ",'381"+ telEmpleado + "','" + direEmpleado + "')";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                conexion.CloseConection();
            }
        }

        public void eliminarEmpleado(int Id)
        {
            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "delete from empleado where IdEmpleado = " + Id + "";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CloseConection();
            }
        }

        public void editarEmpleado(string nombreEmpleado, int dniEmpleado, int telEmpleado, string direEmpleado, int Id)
        {

            try
            {
                cmd.Connection = conexion.OpenConection();

                string query = "update empleado set NombreEmpleado='" + nombreEmpleado + "',DniEmpleado='" + dniEmpleado + "',TelEmpleado='" + telEmpleado + "',DireEmpleado='" + direEmpleado + "' where IdEmpleado =" + Id + "";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CloseConection();
            }


        }

        // TICKET - MULTIPLICACION


    }
}
