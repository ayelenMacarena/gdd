using System;
using System.Collections.Generic;
using System.Configuration;
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
   
        public static DataTable Mostrar(int registrosPorPagina, int numerosPagina, int cliente, String tipo, String termino, String rubros)
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
                sqlComando.Parameters.AddWithValue("@rubros", rubros);

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
        
        public static int tamanio(int registrosPorPagina, int cliente, String tipo, String termino, String rubros)
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
                sqlComando.Parameters.AddWithValue("@rubros", rubros);


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

        public static void Comprar(int publ_id, int cantidad, int comprador, int vendedor)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_EjecutarCompra_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@publ_id", publ_id);
                sqlComando.Parameters.AddWithValue("@cantidad", cantidad);
                sqlComando.Parameters.AddWithValue("@user", comprador);
                sqlComando.Parameters.AddWithValue("@vendedor", vendedor);
                sqlComando.Parameters.AddWithValue("@fecha", ConfigurationManager.AppSettings["dateTimeStamp"].ToString());


                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_EjecutarCompra_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }
            
        }

        public static void Ofertar(int publ_id, int precio, String usuario)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_EjecutarOferta_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@publ_id", publ_id);
                sqlComando.Parameters.AddWithValue("@precio", precio);
                sqlComando.Parameters.AddWithValue("@fecha", ConfigurationManager.AppSettings["dateTimeStamp"].ToString());
                sqlComando.Parameters.AddWithValue("@username", usuario);



                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_EjecutarOferta_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

        }

        public static void InsertarFactura(int publ_id, int cantidad)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_InsertarFactura_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@publ_id", publ_id);
                sqlComando.Parameters.AddWithValue("@date", Convert.ToDateTime(ConfigurationManager.AppSettings["dateTimeStamp"].ToString()));
                sqlComando.Parameters.AddWithValue("@cantidad", cantidad);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_InsertarFactura_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }
   
        }

        public static int ObtenerIdCliente(string usuario)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();
            int idUser;

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_ObtenerIdUser";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@username", usuario);

                SqlParameter parIdUser = new SqlParameter();
                parIdUser.ParameterName = "@idUser";
                parIdUser.Direction = ParameterDirection.Output;
                parIdUser.SqlDbType = SqlDbType.Int;
                sqlComando.Parameters.Add(parIdUser);

                sqlComando.ExecuteNonQuery();

                idUser = (int)sqlComando.Parameters["@idUser"].Value;
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_ObtenerIdUser. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return idUser;
        }

        public static String PasarACodRubros(List<string> filtroRubros)
        {
            String listaCodigosRubro=String.Empty;

            foreach (String detalleRubro in filtroRubros)
            {
                listaCodigosRubro += ObtenerCodRubro(detalleRubro) + ", ";
            }

            //char[] MyChar = { ',' };
            //listaCodigosRubro = listaCodigosRubro.TrimEnd(MyChar);
            return listaCodigosRubro.Remove(listaCodigosRubro.Length-2,2);
        }

        private static string ObtenerCodRubro(string detalleRubro)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();
            int codRubro;

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_ObtenerCodRubro_ComprarOfertar";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@detalleRubro", detalleRubro);

                SqlParameter parIdUser = new SqlParameter();
                parIdUser.ParameterName = "@CodRubro";
                parIdUser.Direction = ParameterDirection.Output;
                parIdUser.SqlDbType = SqlDbType.Int;
                sqlComando.Parameters.Add(parIdUser);

                sqlComando.ExecuteNonQuery();

                codRubro = (int)sqlComando.Parameters["@CodRubro"].Value;
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_ObtenerCodRubro_ComprarOfertar. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            var stringCode = codRubro.ToString();

            return codRubro.ToString();
        }


        public static string ObtenerTodosRubros()
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string rubros = "select rubr_cod from LA_PETER_MACHINE.rubro";
            SqlCommand listRubros = new SqlCommand(rubros, conexion);
            conexion.Close();
            conexion.Open();
            SqlDataReader rub = listRubros.ExecuteReader();
            String rubritos = String.Empty;
            if (rub.HasRows)
            {
                while (rub.Read())
                {
                    rubritos += (rub["rubr_cod"].ToString() + ", ");
                }

            }

            return rubritos.Remove(rubritos.Length - 2, 2);
        }
    }
}
