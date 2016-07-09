using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Para conectar con la base


namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class generarPublicacionSubasta : Form
    {
        string username;
        public generarPublicacionSubasta(string usuario)
        {
            InitializeComponent();

            username = usuario;
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string ultimoNumero = "SELECT TOP 1 publicacion_id from LA_PETER_MACHINE.publicacion order by publicacion_id desc";
            SqlCommand lastNumber = new SqlCommand(ultimoNumero, conexion);
            
            SqlDataReader numero = lastNumber.ExecuteReader();

            while (numero.Read())
            {
                textBoxCod.Text = numero["publicacion_id"].ToString();
            }

            textBox1.Text = usuario;

            string rubros = "select rubr_descripcion_corta from LA_PETER_MACHINE.rubro";
            SqlCommand listRubros = new SqlCommand(rubros, conexion);
            conexion.Close();
            conexion.Open();
            SqlDataReader rub = listRubros.ExecuteReader();
            List<String> rubritos = new List<String>();
            if (rub.HasRows)
            {
                while (rub.Read())
                {
                    rubritos.Add(rub["rubr_descripcion_corta"].ToString());
                }
            }
            comboBox1.DataSource = rubritos;

            conexion.Close();

            conexion.Open();

            string visibilidad = "select visi_descripcion from LA_PETER_MACHINE.visibilidad";
            SqlCommand listaVisi = new SqlCommand(visibilidad, conexion);

            SqlDataReader vis = listaVisi.ExecuteReader();
            List<String> visib = new List<String>();
            if (vis.HasRows)
            {
                while (vis.Read())
                {
                    comboBox2.Items.Add(vis["visi_descripcion"].ToString());
                }
            }

            conexion.Close();
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(textBox3.Text, out unInt))
            {
                MessageBox.Show("El precio debe ser un número");
                return;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Int32 unInt;
            if (!Int32.TryParse(textBox3.Text, out unInt))
            {
                MessageBox.Show("El costo debe ser un número");
                return;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            monthCalendarInicio.Visible = true;
        }

        private void monthCalendarInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarInicio.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            monthCalendarVencimiento.Visible = true;
        }

        private void monthCalendarVencimiento_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox5.Text = monthCalendarVencimiento.SelectionRange.Start.ToShortDateString();
            monthCalendarVencimiento.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            monthCalendarInicio.Visible = true;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            monthCalendarVencimiento.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();

            SqlParameter rdo = new SqlParameter("@rdo", SqlDbType.NVarChar);
            rdo.Size = 255;
            rdo.Direction = ParameterDirection.Output;
            SqlCommand publicar = new SqlCommand("LA_PETER_MACHINE.crearPublicacion", conexion);
            publicar.CommandType = CommandType.StoredProcedure;
            publicar.Parameters.AddWithValue("@username", this.username);
            publicar.Parameters.AddWithValue("@estado", comboBox5.Text);
            publicar.Parameters.AddWithValue("@tipo", "Subasta");
            publicar.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
            if (Convert.ToDecimal(textBox3.Text) < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                return;

            }
            publicar.Parameters.AddWithValue("@precio", textBox3.Text);
            publicar.Parameters.AddWithValue("@costo", DBNull.Value);
            publicar.Parameters.AddWithValue("@rubro", comboBox1.Text);
            publicar.Parameters.AddWithValue("@visibilidad", comboBox2.Text);
            publicar.Parameters.AddWithValue("@preguntas", comboBox3.Text);
            publicar.Parameters.AddWithValue("@envio", comboBox4.Text);
            if (Convert.ToDateTime(textBox4.Text) > Convert.ToDateTime(textBox5.Text))
            {

                MessageBox.Show("La fecha de fin no puede ser menor a la de inicio");
                return;
            }
            publicar.Parameters.AddWithValue("@fecha_inicio", textBox4.Text);
            publicar.Parameters.AddWithValue("@fecha_fin", textBox5.Text);
            publicar.Parameters.AddWithValue("@stock", textBox6.Text);
            publicar.Parameters.Add(rdo);


            publicar.ExecuteNonQuery();
            
            conexion.Close();

            bool usuarioBonificado = Logica_GenerarPublicacion.consultarBonificacion(username);

            if (comboBox5.Text == "Activa" && comboBox2.Text != "Gratis" && !usuarioBonificado)
            {
                Logica_GenerarPublicacion.facturarPublicacion(comboBox2.Text, username, Convert.ToInt32(textBoxCod.Text));
            }
            if (comboBox5.Text == "Activa" && comboBox2.Text != "Gratis" && usuarioBonificado)
            {
                MessageBox.Show("Felicitaciones, tu primer publicacion es gratuita.");
                Logica_GenerarPublicacion.quitarBonificacion(username);
            }

            MessageBox.Show(String.Format("La publicacion se creo de forma: {0}", rdo.Value.ToString()));

            this.Close();
        }





    }
}