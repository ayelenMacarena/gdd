using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Facturas
{
    public class Logica_Facturas
    {
        public static DataTable Mostrar(String fechaDesde, String fechaHasta, String precioDesde, String precioHasta,
                                                String descripcion, String vendedor, int registrosPorPagina, int numerosPagina)
        {
            SqlConnection conexion = conectionDB.getConnection();
            DataTable table = new DataTable("ListadoFacturas");

            try
            {
                conexion.Open();
                SqlCommand buscarFacturas = new SqlCommand("LA_PETER_MACHINE.buscarFacturas", conexion);
                buscarFacturas.CommandType = CommandType.StoredProcedure;

                if (fechaDesde == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@fechaDesde", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                }

                if (fechaHasta == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@fechaHasta", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }

                if (precioDesde == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@precioDesde", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@precioDesde", precioDesde);
                }

                if (precioHasta == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@precioHasta", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@precioHasta", precioHasta);
                }

                if (descripcion == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@descripcion", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@descripcion", descripcion);
                }

                if (vendedor == String.Empty)
                {
                    buscarFacturas.Parameters.AddWithValue("@vendedor", DBNull.Value);
                }
                else
                {
                    buscarFacturas.Parameters.AddWithValue("@vendedor", vendedor);
                }

                buscarFacturas.Parameters.AddWithValue("@registrosPorPagina", registrosPorPagina);
                buscarFacturas.Parameters.AddWithValue("@numerosPagina", numerosPagina);

                buscarFacturas.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(buscarFacturas);
                adapter.Fill(table);
            }

            catch (Exception e)
            {
                table = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado buscarFacturas. " + e.Message);
            }

            finally
            {
                conexion.Close();
            }

            return table;
        }




        public static DataTable tamanio(String fechaDesde, String fechaHasta, String precioDesde, String precioHasta, String descripcion, String vendedor, int registrosPorPagina)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();
            DataTable table = new DataTable("CantidadFacturas");

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Cantidad_Paginas_Facturas";
                sqlComando.CommandType = CommandType.StoredProcedure;


                if (fechaDesde == String.Empty)
                {
                    sqlComando.Parameters.AddWithValue("@fechaDesde", DBNull.Value);
                }
                else
                {
                    sqlComando.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                }


                if (fechaHasta == String.Empty)
                {
                    sqlComando.Parameters.AddWithValue("@fechaHasta", DBNull.Value);
                }
                else
                {
                    sqlComando.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }

                if (precioDesde == String.Empty)
                {
                    sqlComando.Parameters.AddWithValue("@precioDesde", DBNull.Value);
                }
                else
                {
                    sqlComando.Parameters.AddWithValue("@precioDesde", precioDesde);
                }

                if (precioHasta == String.Empty)
                {
                    sqlComando.Parameters.AddWithValue("@precioHasta", DBNull.Value);
                }
                else
                {
                    sqlComando.Parameters.AddWithValue("@precioHasta", precioHasta);
                }

                if (descripcion == String.Empty)
                {
                    sqlComando.Parameters.AddWithValue("@descripcion", DBNull.Value);
                }
                else
                {
                    sqlComando.Parameters.AddWithValue("@descripcion", descripcion);
                }

                if (vendedor == String.Empty)
                  { sqlComando.Parameters.AddWithValue("@vendedor", DBNull.Value); }
                else
                  { sqlComando.Parameters.AddWithValue("@vendedor", vendedor); }


                sqlComando.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlComando);
                adapter.Fill(table);

            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Cantidad_Paginas_Facturas. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return table;
        }

    }
}
