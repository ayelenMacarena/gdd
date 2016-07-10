using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Para conectar con la base


namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class generarPublicacionCompra : Form
    {
        string username;
        public generarPublicacionCompra(string usuario)
        {
            InitializeComponent();
            
            SqlConnection conexion = conectionDB.getConnection();
            conexion.Open();
            string ultimoNumero = "SELECT TOP 1 publicacion_id from LA_PETER_MACHINE.publicacion order by publicacion_id desc";
            SqlCommand lastNumber = new SqlCommand(
                ultimoNumero, conexion);
            username = usuario;
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

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (isNumeric(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
            else { e.Handled = true; }
        }


        public bool isNumeric(Char c)
        {
            if ((c >= '0' && c <= '9'))
            {
                return true;
            }
            return false;
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


        private void monthCalendarInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendarInicio.SelectionRange.Start.ToShortDateString();
            monthCalendarInicio.Visible = false;
        }

        private void textBox5_Click(object sender, EventArgs e)
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

        private void textBox5_Click_1(object sender, EventArgs e)
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
            if (comboBox5.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar un estado");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@estado", comboBox5.Text);
            }

            publicar.Parameters.AddWithValue("@tipo", "Compra Inmediata");
            if (textBoxDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Debe colocar una descripción");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);
            }
            
            if (textBox3.Text != String.Empty && Convert.ToDecimal(textBox3.Text) < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                return;
            }
            if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar un precio");
                return;
            }
            else
            {

                publicar.Parameters.AddWithValue("@precio", textBox3.Text);
            }
            publicar.Parameters.AddWithValue("@costo", DBNull.Value);
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@rubro", comboBox1.Text);
            }

            if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar una visibilidad");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@visibilidad", comboBox2.Text);
            }
            if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar si la publicación acepta o no preguntas");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@preguntas", comboBox3.Text);
            }
            if (comboBox4.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar si la publicación acepta o no envío");
                return;
            }
            else
            {
                publicar.Parameters.AddWithValue("@envio", comboBox4.Text);
            }
            
            if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una fecha de inicio");
                return;
            }
            
            if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una fecha de finalización");
                return;
            }
            
            if (Convert.ToDateTime(textBox4.Text) > Convert.ToDateTime(textBox5.Text))
            {
                MessageBox.Show("La fecha de fin no puede ser menor a la de inicio");
                return;
            }

            if (Convert.ToDateTime(textBox4.Text) < Convert.ToDateTime(ConfigurationManager.AppSettings["dateTimeStamp"].ToString()) ||
                Convert.ToDateTime(textBox5.Text) < Convert.ToDateTime(ConfigurationManager.AppSettings["dateTimeStamp"].ToString()))
            {
                MessageBox.Show("Las fechas no pueden ser anterior a la fecha de hoy");
                return;
            }

            publicar.Parameters.AddWithValue("@fecha_inicio", textBox4.Text);
            publicar.Parameters.AddWithValue("@fecha_fin", textBox5.Text);

            if(numericUpDown1.Text == String.Empty){
                MessageBox.Show("Debe ingresar un stock");
                return;
            }
            publicar.Parameters.AddWithValue("@stock", numericUpDown1.Text);
            publicar.Parameters.Add(rdo);


            publicar.ExecuteNonQuery();
            conexion.Close();

            bool usuarioBonificado = Logica_GenerarPublicacion.consultarBonificacion(username);

            if (comboBox5.Text == "Activa" && comboBox2.Text != "Gratis" && !usuarioBonificado)
            {
                Logica_GenerarPublicacion.facturarPublicacion(comboBox2.Text, username, Convert.ToInt32(textBoxCod.Text));
            }
            if (usuarioBonificado)
            {
                MessageBox.Show("Felicitaciones, tu primer publicacion es gratuita.");
                Logica_GenerarPublicacion.quitarBonificacion(username);
            }

            MessageBox.Show(String.Format("La publicacion se creo de forma: {0}", rdo.Value.ToString()));

            this.Close();
        }







    }
}
