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
   
        public static DataTable Mostrar(int registrosPorPagina, int numerosPagina, int cliente, String tipo, String termino)
        {
            DataTable tablaDatos = new DataTable("ListadoCompras");
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_ListadoComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@registrosPorPagina", registrosPorPagina);
                sqlComando.Parameters.AddWithValue("@numerosPagina", numerosPagina);
                sqlComando.Parameters.AddWithValue("@cliente", cliente);
                sqlComando.Parameters.AddWithValue("@tipo", tipo);
                sqlComando.Parameters.AddWithValue("@terminoBuscado",termino);

                sqlComando.ExecuteNonQuery();

                //Hasta aca se ejecuta solo en la base de datos, no los muestra en la app =>

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(sqlComando);
                adaptadorDatos.Fill(tablaDatos);
            }
            catch (Exception e)
            {
                tablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_ListadoComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return tablaDatos;
        }




        public static int tamanio(int registrosPorPagina, int cliente, String tipo, String termino)
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

                sqlComando.Parameters.AddWithValue("@registrosPorPagina", registrosPorPagina);

                SqlParameter parTotalPaginas = new SqlParameter();
                parTotalPaginas.ParameterName = "@totalDePaginas";
                parTotalPaginas.Direction = ParameterDirection.Output;
                parTotalPaginas.SqlDbType = SqlDbType.Int;
                sqlComando.Parameters.Add(parTotalPaginas);

                sqlComando.Parameters.AddWithValue("@cliente", cliente);
                sqlComando.Parameters.AddWithValue("@tipo", tipo);
                sqlComando.Parameters.AddWithValue("@terminoBuscado", termino);


                sqlComando.ExecuteNonQuery();

                totalPaginas = (int)sqlComando.Parameters["@totalDePaginas"].Value; 
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

        public static void llenarComboRubros(ComboBox rubros)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            SqlCommand loginProcedure = new SqlCommand("LA_PETER_MACHINE.SP_ListadoRubros", conexion);
            loginProcedure.CommandType = CommandType.StoredProcedure;

            SqlDataReader dataRubros = loginProcedure.ExecuteReader();
            List<String> listaRubros = new List<String>();

            if (dataRubros.HasRows)
            {
                while (dataRubros.Read())
                {
                   rubros.Items.Add(dataRubros["rubr_descripcion_corta"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Error al ejecutar el SP_ListadoRubros");
            }
            conexion.Close();
        }
    }
}
