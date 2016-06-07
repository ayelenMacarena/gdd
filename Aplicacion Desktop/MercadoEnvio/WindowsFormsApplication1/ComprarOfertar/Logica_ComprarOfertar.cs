using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    class Logica_ComprarOfertar
    {
   
        public static DataTable Mostrar(int registrosPorPagina, int numerosPagina, int cliente)
        {
            DataTable tablaDatos = new DataTable("ListadoPublicaciones");
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Listado_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parRegistrosPorPagina = new SqlParameter();
                parRegistrosPorPagina.ParameterName = "@registrosPorPagina";
                parRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                parRegistrosPorPagina.Value = registrosPorPagina;
                sqlComando.Parameters.Add(parRegistrosPorPagina);

                SqlParameter parNumerosPagina = new SqlParameter();
                parNumerosPagina.ParameterName = "@numerosPagina";
                parNumerosPagina.SqlDbType = SqlDbType.Int;
                parNumerosPagina.Value = numerosPagina;
                sqlComando.Parameters.Add(parNumerosPagina);

                SqlParameter parCliente = new SqlParameter();
                parCliente.ParameterName = "@cliente";
                parCliente.SqlDbType = SqlDbType.Int;
                parCliente.Value = cliente;
                sqlComando.Parameters.Add(parCliente);

                sqlComando.ExecuteNonQuery();

                //Hasta aca se ejecuta solo en la base de datos, no los muestra en la app =>

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(sqlComando);
                adaptadorDatos.Fill(tablaDatos);
            }
            catch (Exception e)
            {
                tablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Listado_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return tablaDatos;
        }




        public static int tamanio(int registrosPorPagina, int cliente)
        {
            int totalPaginas = 1;
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Cantidad_Paginas_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parRegistrosPorPagina = new SqlParameter();
                parRegistrosPorPagina.ParameterName = "@registrosPorPagina";
                parRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                parRegistrosPorPagina.Value = registrosPorPagina;
                sqlComando.Parameters.Add(parRegistrosPorPagina);

                SqlParameter parTotalDePaginas = new SqlParameter();
                parTotalDePaginas.ParameterName = "@totalDePaginas";
                parTotalDePaginas.Direction = ParameterDirection.Output;
                parTotalDePaginas.SqlDbType = SqlDbType.Int;
                sqlComando.Parameters.Add(parTotalDePaginas);

                SqlParameter parCliente = new SqlParameter();
                parCliente.ParameterName = "@cliente";
                parCliente.SqlDbType = SqlDbType.Int;
                parCliente.Value = cliente;
                sqlComando.Parameters.Add(parCliente);

                sqlComando.ExecuteNonQuery();

                totalPaginas = (int)sqlComando.Parameters[@totalPaginas].Value; 
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Cantidad_Paginas_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return totalPaginas;
        }




        public static DataTable Buscar(String termino)
        {
            DataTable tablaDatos = new DataTable("ListadoPublicaciones");
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Buscador_Publicaciones";
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parTerminoBuscado = new SqlParameter();
                parTerminoBuscado.ParameterName = "@terminoBuscado";
                parTerminoBuscado.SqlDbType = SqlDbType.VarChar;
                parTerminoBuscado.Size = termino.Length;
                parTerminoBuscado.Value = termino;
                sqlComando.Parameters.Add(parTerminoBuscado);

                sqlComando.ExecuteNonQuery();

                //Hasta aca se ejecuta solo en la base de datos, no los muestra en la app =>

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(sqlComando);
                adaptadorDatos.Fill(tablaDatos);
            }
            catch (Exception e)
            {
                tablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Buscador_Publicaciones. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return tablaDatos;
        }



        public static void llenarComboRubros(ComboBox rubros)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand("select rubr_descripcion_corta from LA_PETER_MACHINE.rubro", sqlConexion);

                SqlDataReader respuesta = sqlComando.ExecuteReader();

                while (respuesta.Read() != null)
                {
                    rubros.Items.Add(respuesta.GetString(0));
                }

                respuesta.Close();

                //Hasta aca se ejecuta solo en la base de datos, no los muestra en la app =>

            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar llenar el Combo Box Rubros. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }


        }



    }
}
