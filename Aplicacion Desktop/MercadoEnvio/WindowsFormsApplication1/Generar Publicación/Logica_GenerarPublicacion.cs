using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public class Logica_GenerarPublicacion
    {
        public static void facturarPublicacion(string visibilidad, string username, int idPublicacion)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_FacturarPublicacion_GenerarPublicacion";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@visibilidad", visibilidad);
                sqlComando.Parameters.AddWithValue("@usuario", username);
                sqlComando.Parameters.AddWithValue("@publicacion", idPublicacion);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_FacturarPublicacion_GenerarPublicacion. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }    
        }

        public static bool consultarBonificacion(string username)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();
            bool bonificado;

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_ConsultarUsuarioBonificado_GenerarPublicacion";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@username", username);

                SqlParameter parBonificado = new SqlParameter();
                parBonificado.ParameterName = "@estaBonificado";
                parBonificado.Direction = ParameterDirection.Output;
                parBonificado.SqlDbType = SqlDbType.Bit;
                sqlComando.Parameters.Add(parBonificado);

                sqlComando.ExecuteNonQuery();

                bonificado = (bool)sqlComando.Parameters["@estaBonificado"].Value; 
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado SP_ConsultarUsuarioBonificado_GenerarPublicacion. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }

            return bonificado;
        }

        public static void quitarBonificacion(string username)
        {
            SqlConnection sqlConexion = conectionDB.getConnection();

            try
            {
                sqlConexion.Open();

                SqlCommand sqlComando = new SqlCommand();
                sqlComando.Connection = sqlConexion;
                sqlComando.CommandText = "LA_PETER_MACHINE.SP_QuitarBonificado_GenerarPublicacion";
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlComando.Parameters.AddWithValue("@username", username);

                sqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado LA_PETER_MACHINE.SP_QuitarBonificado_GenerarPublicacion. " + e.Message);
            }

            finally
            {
                sqlConexion.Close();
            }   
        }
    }
}
