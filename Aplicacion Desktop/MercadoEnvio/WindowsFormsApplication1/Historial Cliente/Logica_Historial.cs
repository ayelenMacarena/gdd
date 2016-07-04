using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public class Logica_Historial
    {
        public static DataTable Mostrar(int registrosPorPagina, int numerosPagina, String usuario, int tipo)
        {
            DataTable tablaDatos = new DataTable("ListadoHistorial");
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Listado_Historial";
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

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@cliente";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Value = usuario;
                sqlComando.Parameters.Add(parUsuario);

                SqlParameter parTipo = new SqlParameter();
                parTipo.ParameterName = "@tipo";
                parTipo.SqlDbType = SqlDbType.Int;
                parTipo.Value = tipo;
                sqlComando.Parameters.Add(parTipo);


                sqlComando.ExecuteNonQuery();

                //Hasta aca se ejecuta solo en la base de datos, no los muestra en la app =>

                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(sqlComando);
                adaptadorDatos.Fill(tablaDatos);
            }
            catch (Exception e)
            {
                tablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Listado_Historial. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return tablaDatos;
        }


        public static int tamanio(int registrosPorPagina, String usuario, int tipo)
        {
            int totalPaginas = 1;
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_Cantidad_Paginas_Historial";
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

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@cliente";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Value = usuario;
                sqlComando.Parameters.Add(parUsuario);

                SqlParameter parTipo = new SqlParameter();
                parTipo.ParameterName = "@tipo";
                parTipo.SqlDbType = SqlDbType.Int;
                parTipo.Value = tipo;
                sqlComando.Parameters.Add(parTipo);

                sqlComando.ExecuteNonQuery();

                totalPaginas = (int)sqlComando.Parameters[@totalPaginas].Value;
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_Cantidad_Paginas_Historial. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return totalPaginas;
        }

        public static int ObtenerIdUsuario(string usuario)
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


        public static decimal ObtenerCalificacionProm(int idUsuario)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();
            decimal calificacionPromedio;

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_ObtenerCalificacionProm_Historial";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@idUsuario", idUsuario);

                SqlParameter parIdUser = new SqlParameter();
                parIdUser.ParameterName = "@calificacionPromedio";
                parIdUser.Direction = ParameterDirection.Output;
                parIdUser.SqlDbType = SqlDbType.Float;
                sqlComando.Parameters.Add(parIdUser);

                sqlComando.ExecuteNonQuery();

                calificacionPromedio = Convert.ToDecimal(sqlComando.Parameters["@calificacionPromedio"].Value);
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_ObtenerCalificacionProm_Historial. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return calificacionPromedio;

        }

        internal static string ObtenerPendientesDeCalificacion(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
