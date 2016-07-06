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
    }
}
